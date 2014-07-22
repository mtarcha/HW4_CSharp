using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Pupil
    {
        public virtual void Study()
        {
        }
        public virtual void Read()
        {
        }
        public virtual void Write()
        {
        }
        public virtual void Relax()
        {
        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Studying excellently");
        }
        public override void Read()
        {
            Console.WriteLine("Reading excellently");
        }
        public override void Write()
        {
            Console.WriteLine("Writing excellently");
        }
        public override void Relax()
        {
            Console.WriteLine("Relaxing excellently");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Studying good");
        }
        public override void Read()
        {
            Console.WriteLine("Reading good");
        }
        public override void Write()
        {
            Console.WriteLine("Writing good");
        }
        public override void Relax()
        {
            Console.WriteLine("Relaxing good");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Studying bad");
        }
        public override void Read()
        {
            Console.WriteLine("Reading bad");
        }
        public override void Write()
        {
            Console.WriteLine("Writing bad");
        }
        public override void Relax()
        {
            Console.WriteLine("Relaxing bad");
        }
    }
}

