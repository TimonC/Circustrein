﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Train
    {
        private List<Wagon> wagons = new List<Wagon>();
        private List<Animal> animals = new List<Animal>();
        public IEnumerable<Wagon> Wagons { get => wagons; }
<<<<<<< HEAD
        public List<Animal> Animals { get => animals; set => animals = value; }
=======
        //  public List<Wagon> Wagons { get => wagons; set => wagons = value; }
        public List<Animal> Animals { get => animals; }
>>>>>>> parent of 666d1f1... Encapsulation werkt nu met oude Algoritme
        public Train()
        {

        }
        public void animalCheck(Animal animal)
        {
            if (animal.diet == Animal.Diet.Carnivoor)
            {
<<<<<<< HEAD
                NewWagon(animal);
=======
                if (wagon.CheckCompatability(animal) && wagon.CheckPoints(animal) == true)
                {
                    animal.Used = true;
                    wagon.capacity -= Convert.ToInt32(animal._Points);
                }

>>>>>>> parent of 666d1f1... Encapsulation werkt nu met oude Algoritme
            }
            else
            {
                foreach (Wagon wagon in Wagons)
                {  
                    if (wagon.fullCheck(animal) == true)
                    {
                       
                    }
                        NewWagon(animal);
             
                }
              
                  
            }
          //  if (!animal.used)
          //  {
           //     NewWagon(animal);

         //   }

        }



        public void NewWagon(Animal animal)
        {
            if (animal.diet == Animal.Diet.Carnivoor)
            {
                Wagon wagon = new Wagon(10);
                wagons.Add(wagon);
                wagon.AddCarnivor(animal);
                //animals.Remove(animal);
            }
            else
            {
                Wagon wagon2 = new Wagon(10);
                wagons.Add(wagon2);
                animal.used = true;
                animalCheck(animal);
            }
        }

    }

}
