using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace dojodachi.Models
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static Dachi GetObjectFromJson<Dachi>(this ISession session, string key)
        {
            string value = session.GetString(key);
            return value == null ? default(Dachi) : JsonConvert.DeserializeObject<Dachi>(value);
        }
    }

    public class Dachi
    {
        public int Happiness{get;set;}
        public int Fullness{get;set;}
        public int Energy{get;set;}
        public int Meals{get;set;}
        public bool Alive{get;set;}
        public bool Win{get;set;}
        public string Mood{get;set;}

        public Dachi(int happiness=20, int fullness=20, int energy=50, int meals=3, bool alive=true, bool win=false, string mood="~/lib/normal.jpg")
        {
            this.Happiness = happiness;
            this.Fullness = fullness;
            this.Energy = energy;
            this.Meals = meals;
            this.Alive = alive;
            this.Win = win;
            this.Mood = mood;
        }

        public void Play(int happiness, int energy)
        {
            Random PercentChance = new Random();
            int decider = PercentChance.Next(1,40);
            if (this.Energy >= 5)
            {
                if (decider < 10)
                {
                    Random randHappy = new Random();
                    this.Happiness += randHappy.Next(5,10);
                    this.Mood="~/lib/play.png";
                }
                else
                {
                    this.Energy -= 5;
                    this.Mood="Your pet didn't really want to play, but wanted to do something else....";
                }
            }
            else
            {
                this.Mood="You have insufficient energy!";
            }
        }

        public void Feed(int fullness, int meals)
        {
            Random PercentChance = new Random();
            int decider = PercentChance.Next(1, 40);
            if (this.Meals > 0)
            {
                if (decider < 10)
                {
                    Random randFill = new Random();
                    this.Fullness += randFill.Next(5,10);
                    this.Mood="~/lib/eat.jpg";
                }
                else
                {
                    this.Meals -= 1;
                    this.Mood="Your pet didn't like the food....";
                }
            }
            else
            {
                this.Mood="You do not have any more meals.";
            }
        }

        public void Work(int energy, int meals)
        {
            if (this.Energy >= 5)
            {
                this.Energy -= 5;
                Random randMeal = new Random();
                this.Meals += randMeal.Next(1,3);
                this.Mood="~/lib/work.jpg";
            }
            else
            {
                this.Mood="You have insufficient energy!";
            }
        }

        public void Sleep(int happiness, int fullness, int energy)
        {
            if (this.Fullness >= 5 || this.Happiness >= 5)
            {
                this.Fullness -= 5;
                this.Happiness -= 5;
                this.Energy += 15;
                this.Mood="~/lib/sleep.png";
            }
            else
            {
                this.Mood="You either have insufficient happiness or fullness levels to rest now...your dachi has died....";
            }
        }

        public bool IsAlive(bool alive)
        {
            if (this.Fullness < 1 || this.Happiness < 1)
            {
                this.Mood="~/lib/death.jpg";
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsWin(bool win)
        {
            if (this.Energy > 99 && this.Fullness > 99 && this.Happiness > 99)
            {
                this.Mood="~/lib/win.jpg";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}