// AIExample.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "AIExample.h"
#define _USE_MATH_DEFINES

#include <math.h>

CTankActions tank;

int CompareAngles(int a, int b)
{
    while (a < 0)
    {
		a += 360;
    }
	while (b < 0)
    {
		b += 360;
    }
	int angle = b % 360 - a % 360;
	if(angle > 180)
	{
		angle -= 360;
	}
	if(angle < -180)
	{
		angle += 360;
	}
	return angle;
}

extern "C"
{
	AI_API void SetCoords(int x, int y)
	{
		tank.x = x;
		tank.y = y;
	}
	AI_API void SetAngle(int angle)
	{
		tank.baseAngle = angle;
	}
	AI_API void SetTurretAngle(int angle)
	{
		tank.turretAngle = angle;
	}
	AI_API void SetCollisionStatus(bool isCollided)
	{
		tank.isCollided = isCollided;
	}
	AI_API void SetLivePercent(int percent) 
	{
		if(tank.liveDamage > 0)
		{
			--tank.liveDamage;
		}
		tank.liveDamage += tank.livePercent - percent;
		tank.livePercent = percent; 

	}
	AI_API void SetVisilbeEnemyCount(int count) 
	{
		tank.enemies.clear();
		tank.enemies.resize(count);
	}
	AI_API void SetEnemyProteries(int enemyID, int x, int y, int angle, int turretAngle, int livePercent)
	{
		tank.enemies[enemyID].x = x;
		tank.enemies[enemyID].y = y;
		tank.enemies[enemyID].health = livePercent;
		tank.enemies[enemyID].turretAngle = turretAngle;
	}
	AI_API int GetDirection()
	{
		if(tank.strateg == attacking)
		{
			return 1;
		}
		if(tank.strateg == retreating)
		{
			return -1;
		}
		return 0;
	}
	AI_API int GetRotateDirection()
	{
		if(CompareAngles(tank.baseAngle, tank.movingAngle) > 0)
		{
			return 1;
		}
		if(CompareAngles(tank.baseAngle, tank.movingAngle) < 0)
		{
			return -1;
		}
		if(tank.strateg == searching)
		{
			return 1;
		}
		return 0;
	}
	AI_API int GetRotateSpeed()
	{
		if(tank.strateg == searching)
		{
			return 10;
		}
		if(tank.fireDistance != -1 && abs(CompareAngles(tank.baseAngle, tank.movingAngle)) < 10)
		{
			return abs(CompareAngles(tank.baseAngle, tank.movingAngle));
		}
		return 10;
	}
	AI_API int GetTurretRotateDirection()
	{
		if(CompareAngles(tank.turretAngle, tank.fireAngle) > 0)
		{
			return 1;
		}
		if(CompareAngles(tank.turretAngle, tank.fireAngle) < 0)
		{
			return -1;
		}
		return 0;
	}
	AI_API int GetTurretRotateSpeed()
	{
		if(abs(CompareAngles(tank.turretAngle, tank.fireAngle)) < 20)
		{
			return abs(CompareAngles(tank.turretAngle, tank.fireAngle));
		}
		return 20;
	}
	AI_API int GetFireDistance()
	{
		if(abs(CompareAngles(tank.turretAngle, tank.fireAngle)) < (1800 / tank.fireDistance))
		{
			return tank.fireDistance;
		}
		return -1;
	}

	double GetDistance (int x1, int x2, int y1, int y2)
	{
		return sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
	}

	void Retreat()
	{
		double newX = tank.x - 100 * sin(tank.baseAngle * M_PI / 180);
		double newY = tank.y + 100 * cos(tank.baseAngle * M_PI / 180);
		int rotation = 0;
		if(newX < 100)
		{
			rotation += 5;
		}
		if(newX > 540)
		{
			rotation += 5;
		}
		if(newY < 100)
		{
			rotation += 5;
		}
		if(newY > 380)
		{
			rotation += 5;
		}
		if(tank.isCollided)
		{
			rotation = 10;
		}
		tank.movingAngle = tank.baseAngle - rotation;
	}

	AI_API void Update()
	{
		tank.strateg = searching;
		tank.movingAngle = tank.baseAngle;
		tank.fireAngle = tank.baseAngle;
		int retreatRatio = -tank.livePercent / 10 + 10 * tank.isCollided + tank.liveDamage;
		int preferedEnemy = -1;
		int enemyX = 0;
		int enemyY = 0;
		for(unsigned int i = 0; i < tank.enemies.size(); i++)
		{
			if(GetDistance(tank.enemies[i].x, tank.x, tank.enemies[i].y, tank.y) * tank.enemies[i].health < preferedEnemy || preferedEnemy == -1)
			{
				preferedEnemy = GetDistance(tank.enemies[i].x, tank.x, tank.enemies[i].y, tank.y) * tank.enemies[i].health;
				enemyX = tank.enemies[i].x;
				enemyY = tank.enemies[i].y;
			}
			if(abs(CompareAngles(tank.enemies[i].turretAngle, 180 - tank.turretAngle)) < 45)
			{
				retreatRatio += (tank.enemies[i].health - tank.livePercent) / 5;
			}
			else
			{
				retreatRatio -= 5;
			}
		}
		if(retreatRatio > 10)
		{
			tank.retreatTime = 200;
			tank.targetAngle = preferedEnemy;
		}
		else if(retreatRatio < -10)
		{
			if(GetDistance(tank.x, enemyX, tank.y, enemyY) > 100)
			{
				tank.strateg = attacking;
			}
			else
			{
				tank.strateg = camping;
			}
		}
		else
		{
			if(preferedEnemy != -1)
			{
				tank.strateg = camping;
			}
		}
		if(tank.retreatTime > 0)
		{
			tank.retreatTime--;
			tank.strateg = retreating;
		}
		if(tank.strateg == retreating)
		{
			Retreat();
		}
		if(preferedEnemy == -1)
		{
			tank.fireDistance = -1;
			return;
		}
		tank.fireDistance = sqrt((tank.x - enemyX) * (tank.x - enemyX) + (tank.y - enemyY) * (tank.y - enemyY)) / 1;
		tank.fireAngle = -atan2(enemyY - tank.y, tank.x - enemyX) * 180 / M_PI - 90;
		if(tank.strateg == attacking || tank.strateg == camping)
		{
			tank.movingAngle = tank.fireAngle;
		}
	}
}