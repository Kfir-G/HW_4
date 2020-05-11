﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW_4
{
    class Stack
    {
        //-----data fields-----
        Animal[] SickAnimals;
        int Pionter;

        //-----Constructors----
        public Stack(int sizeArr)
        {
            Pionter = 0;
            this.SickAnimals = new Animal[sizeArr];
        }
        public Stack() : this(1)
        {

        }

        //-------methods-------
        public Animal GetSick(int idx)
        {
            return SickAnimals[idx];
        }
        public bool IsEmpty()
        {
            if (SickAnimals[0] == null)
                return true;
            return false;
        }
        public bool IsFull()
        {
            if (SickAnimals[Pionter] == null)
                return false;
            return true;
        }
        public int GetLastPos()
        {
            return Pionter;
        }
        public void Push(Animal animalTemp)
        {
            SickAnimals[Pionter] = animalTemp;
            Pionter++;
            return;
        }
        public Animal Pop()
        {
            Animal animalTemp = SickAnimals[Pionter];
            Pionter--;
            return animalTemp;
        }
    }
}
