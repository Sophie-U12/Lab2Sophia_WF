using Lab2Sophia_WF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Sophia_WF.Models
{
    public class Wind
    {
        public WindDirection Direction { get; set; }
        public double Power { get; set; }

        public Wind()
        {
            Direction = new WindDirection();
            Power = 0;
        }
        public Wind(WindDirection direction, double power)
        {
            Direction = direction;
            Power = power;
        }
        public static string WindDirectionToString(WindDirection direction)
        {
            switch (direction)
            {
                case WindDirection.North: return "Північ";
                case WindDirection.South: return "Південь";
                case WindDirection.West: return "Захід";
                case WindDirection.East: return "Схід";
                default: return "";
            }
        }

        public override string ToString()
        {
            return $"Напрямок: {WindDirectionToString(Direction)}. Швидкість: {Math.Round(Power, 2)} м/c.";
        }
    }
}
