﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        List<Dier> wachtrij = new List<Dier>();
        List<Dier> dieren = new List<Dier>();
        List<Dier> vleeseters = new List<Dier>();
        List<Dier> planteters = new List<Dier>();
        Dier leeuw = new Dier("Leeuw", "Vlees", 3);
        Dier olifant = new Dier("Olifant", "Plant", 5);
        Dier aap = new Dier("Aap", "Plant", 2);
        Dier konijn = new Dier("Konijn", "Plant", 1);
        Dier zeehond = new Dier("Zeehond", "Vlees", 2);
        Dier parakiet = new Dier("Parakiet", "Plant", 1);
   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {


            

            vleeseters = dieren.Where(p => p.Diet == "Vlees").ToList();
            planteters = dieren.Where(p => p.Diet == "Plant").ToList();
            VleesCheck();
            listBox1.DataSource = wachtrij;
            listBox1.DisplayMember = "Info";
            listBox2.DataSource = vleeseters;
            listBox2.DisplayMember = "Info";
            listBox3.DataSource = planteters;
            listBox3.DisplayMember = "Info";
           
           



        }
        public void VleesCheck()
        {
          //  var query = planteters.Any(p => p.Points > vleeseters.Points);
            var query1 = vleeseters.Where(dir1 => planteters.Any(dir2 => dir2.Points > dir1.Points));
            var query2 = planteters.Where(x1 => vleeseters.Any(x2 => x1.Points > x2.Points));
            foreach (Dier dir1 in query1)
            {
                wachtrij.Add(dir1);
                break;
            }
            foreach (Dier x1 in query2)
            {
                wachtrij.Add(x1);
                break;
            }
            PuntenCheck();
            /*
                        foreach (Dier vlees in vleeseters)
                        {
                            foreach (Dier plant in vleeseters)
                                if (plant.Points > vlees.Points)
                                {
                                    wachtrij.Add(vlees);
                                    wachtrij.Add(plant);
                                }
                        }
                        */
            //  int klein = planteters.Where(p => p.Size == "Middel");
            // var wachtrij = planteters.Where(item => vleeseters.Select(item2 => item2).Contains());
            // var wachtrij = planteters.Where(p => p.Size == "Middel");   

        }
        public void PuntenCheck()
        {
        }
          
        /*      public class SorteerVlees : IComparer<Dier>
              {
                  public int Compare(Dier x, Dier y)
                  {
                      if ((x.Diet == "Vlees") && (y.Diet == "Plant"))
                      {
                          if(y.Size > x.Size)
                          {

                          }
                          else
                          {
                              wachtrij.Add(x);
                          }
                      }
                      throw new NotImplementedException();
                  }
              }
      */
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(leeuw);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(olifant);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(aap);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(konijn);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(zeehond);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            dieren.Add(parakiet);
        }
    }
}
