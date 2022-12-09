﻿using System;


class Body
{
    private string name;

    private double posX;
    private double posY;
    private double mass;
    private double radius;
    private double velX;
    private double velY;

    private double F;
    private double Fx;
    private double Fy;


    public Body(string n, float x, float y, float m, float r, float vx, float vy)
    {
        name = n;
        posX = x;
        posY = y;
        mass = m;
        radius = r;
        velX = vx;
        velY = vy;
    }

    public Body(string line)
    {
        string[] data = line.Split(";");

        name = data[0];
        mass = double.Parse(data[1]);
        radius = double.Parse(data[2]);
        posX = double.Parse(data[3]);
        posY = double.Parse(data[4]);
        velX = double.Parse(data[5]);
        velY = double.Parse(data[6]);
    }

    public double getMass()
    {
        return mass;
    }

    public double getRadius()
    {
        return (radius / 4);
    }

    public double getPosX()
    {
        return posX;
    }

    public double getPosY()
    {
        return posY;
    }

    public double getVelX()
    {
        return velX;
    }

    public double getVelY()
    {
        return velY;
    }

    public double getF()
    {
        return F;
    }

    public double getFx()
    {
        return Fx;
    }

    public double getFy()
    {
        return Fy;
    }

    public void setPosX(double x)
    {
        posX = x;
    }

    public void setPosY(double y)
    {
        posY = y;
    }

    public void setVelX(double x)
    {
        velX = x;
    }

    public void setVelY(double y)
    {
        velY = y;
    }

    public void setF(double x)
    {
        F = x;
    }

    public void setFx(double x)
    {
        Fx = x;
    }

    public void setFy(double x)
    {
        Fy = x;
    }

    public double getDistance(Body other_body)
    {
        return Math.Sqrt(Math.Pow((this.getPosX() - other_body.getPosX()), 2) + Math.Pow((this.getPosY() - other_body.getPosY()), 2));
    }
    public string formatOutputFile()
    {
        return String.Format("{0};{1};{2};{3};{4};{5};{6}", name, mass, radius, posX, posY, velX, velY);
    }


}