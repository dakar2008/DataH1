using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1
{
    internal enum SidePlacement
    {
        Left = 0,
        Right = 1,
    }

    internal class Human
    {
        public Head Head { get; set; }
        public void CanSpeak()
        {
            Console.WriteLine("SPEAK SPEAK SPEAK SPEAK");
        }
        public void CanThink()
        {
            Console.WriteLine("THINKING THINKING THINKING THINKING");
        }
        public void CanHear()
        {
            Console.WriteLine("HEARING HEARING HEARING HEARING");
        }
    }

    internal class Head
    {
        public Brain Brain { get; set; }
        public List<Eye> Eyes { get; set; }
        public List<Ear> Ears { get; set; }
        public Nose Nose { get; set; }
        public Mouth Mouth { get; set; }

    }
    internal class Brain
    {
        /// <summary>
        /// Intelligence Quotient
        /// </summary>
        public int IQ { get; set; }
        /// <summary>
        /// Brain Capacity
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// Is the brain alive or not
        /// </summary>
        public bool Alive { get; set; }
    }
    internal class Eye
    {
        /// <summary>
        /// Placement of the eye, left or right
        /// </summary>
        public SidePlacement Placement { get; set; }
        /// <summary>
        /// Color of the eye
        /// </summary>
        public Color Color { get; set; }
    }
    internal class Ear
    {
        /// <summary>
        /// Placement of the ear, left or right
        /// </summary>
        public SidePlacement Placement { get; set; }
        /// <summary>
        /// Size of the ear
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// Is the ear working or not
        /// </summary>
        public bool Working { get; set; }
    }
    internal class Nose
    {
        /// <summary>
        /// Size of the nose
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// Is the nose flat or not
        /// </summary>
        public bool Flat { get; set; }
        /// <summary>
        /// Can the nose smell or not
        /// </summary>
        public bool CanSmell { get; set; }
    }
    internal class Mouth
    {
        /// <summary>
        /// Width of the mouth in mm
        /// </summary>
        public int Width { get; set; }
    }
}