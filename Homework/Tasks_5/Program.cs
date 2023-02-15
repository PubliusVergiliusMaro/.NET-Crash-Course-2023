﻿using Newtonsoft.Json;
namespace Tasks_5
{
	public class Weapon
	{

		 int range;
		 float caliber;
		 int magazine;
		 int maxSize;

		public Weapon() { }
		public Weapon(int range, float caliber, int maxSize)
		{
			if (range < 0)
				throw new ArgumentException("Range cannot be negative.");
			this.range = range;
			if (caliber < 0)
				throw new ArgumentException("Caliber cannot be negative.");
			this.caliber = caliber;
			if (maxSize < 0)
				throw new ArgumentException("Max size cannot be negative.");
			this.maxSize = maxSize;
			magazine = maxSize;
		}
		public void Initialize(int range, float caliber, int maxSize)
		{
			if (range < 0)
				throw new ArgumentException("Range cannot be negative.");
			this.range = range;
			if(caliber < 0)
				throw new ArgumentException("Caliber cannot be negative.");
			this.caliber = caliber;
			if (maxSize < 0)
				throw new ArgumentException("Max size cannot be negative.");
			this.maxSize = maxSize;
			magazine = maxSize;
		}
		public bool Shot()
		{
			if (magazine > 0)
			{
				magazine--;
				return true;
			}
			else return false;
		}
		public void Recharge()
		{
			this.magazine = maxSize;
		}
		public void Save()
		{
			string path = "Data.json";
			if (File.Exists(path))
			File.WriteAllText(path, JsonConvert.SerializeObject(this));
		
		}
		public static Weapon Load()
		{
			string path = "Data.json";
			if (File.Exists(path))
			{
				return JsonConvert.DeserializeObject<Weapon>(File.ReadAllText("Data.json"));
			}
			else
			{
				Console.WriteLine("File does not exist!");
				return null;
			}
		}
		public override string ToString()
		{
			return
				$"Range - {this.range} m\n" +
				$"Caliber - {this.caliber}\n" +
				$"Max Ammo in magazine - {this.maxSize}\n" +
				$"Current number of bullets in magazine - {this.magazine}\n" +
				$"{new string('-', 70)}";
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Weapon weapones = new Weapon(1000,4.56F, 30);
			weapones.Save();

			//Weapon weapon = Weapon.Load();

			
			Console.WriteLine(weapones.ToString());
			
			Console.ReadKey();
		}
	}
}