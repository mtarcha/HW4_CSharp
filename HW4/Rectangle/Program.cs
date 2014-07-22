using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{

    class Program
    {
        static void Main(string[] args)
        {
            //Задача№1 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            Rectangle r = new Rectangle(2, 3);
            Console.WriteLine("Square={0},\nPerimeter={1}", r.Area, r.Perimeter);
            
            ///Задача№2//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
            Point _a = new Point(1, 0, "A");
            Point _b = new Point(-1, 0, "B");
            Point _c = new Point(0, 1, "C");
            Point _d = new Point(1, 1, "D");
            Point _e = new Point(0, 2, "E");
            Figure _f1 = new Figure(_a, _b, _c);
            Figure _f2 = new Figure(_a, _b, _c, _d);
            Figure _f3 = new Figure(_a, _b, _c, _d, _e);

            _f1.PerimeterCalculator();
            _f2.PerimeterCalculator();
            _f3.PerimeterCalculator();

            Console.WriteLine("Figure={0},\nPerimeter={1}", _f1.Name_of_Figure, _f1.Perimeter);
            Console.WriteLine("Figure={0},\nPerimeter={1}", _f2.Name_of_Figure, _f2.Perimeter);
            Console.WriteLine("Figure={0},\nPerimeter={1}", _f3.Name_of_Figure, _f3.Perimeter);
            */
            ///Задача№3////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
            User _user = new User("Myrosya", "Slava", "Tarcha", 21, DateTime.Now);
            Console.WriteLine("login={0},\nfirst name={1},\nlast name={2},\nage={3},\ndate={4}", _user.Login, _user.FirstName, _user.LastName, _user.Age, _user.Date);
            */
            ///Задача№4//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
           /*
            Converter _converter = new Converter(11.9, 16.5, 0.37);
            Console.WriteLine("Input sum of moneu on hrivna");
            double _sum = Convert.ToDouble(Console.ReadLine());
            //var1 вказує яку саме валюту вибрав користувач (1-usd,2-eur,3-rub) 
            Console.WriteLine("Input number of currency: 1 if usd,2 if eur,3 if rub");
            int _value = Convert.ToInt32(Console.ReadLine());

            switch (_value)
            {
                case 1: Console.WriteLine("{0} in usd is {1}", _sum, _sum * _converter.Hrn_Usd()); break;
                case 2: Console.WriteLine("{0} in eur is {1}", _sum, _sum * _converter.Hrn_Eur()); break;
                case 3: Console.WriteLine("{0} in rub is {1}", _sum, _sum * _converter.Hrn_Rub()); break;
            }

            Console.WriteLine("Input sum of moneu on currency");
            _sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the currency in which the amount of money being put: 1 if usd,2 if eur,3 if rub");
            _value = Convert.ToInt32(Console.ReadLine());

            switch (_value)
            {
                case 1: Console.WriteLine("{0} in grn is {1}", _sum, _sum * _converter.Usd_Hrn()); break;
                case 2: Console.WriteLine("{0} in grn is {1}", _sum, _sum * _converter.Eur_Hrn()); break;
                case 3: Console.WriteLine("{0} in grn is {1}", _sum, _sum * _converter.Rub_Hrn()); break;
            }
            * */
            ////Задача№6////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
            ExcelentPupil _excelentPupil = new ExcelentPupil();
            GoodPupil _goodPupil = new GoodPupil();
            BadPupil _badPupil = new BadPupil();

            ClassRoom clas = new ClassRoom(_excelentPupil,_goodPupil,_badPupil);

            Console.WriteLine("In the classromm pupils can studing like this:");
            _excelentPupil.Study();
            _goodPupil.Study();
            _badPupil.Study();

            Console.WriteLine("Reading like this:");
            _excelentPupil.Read();
            _goodPupil.Read();
            _badPupil.Read();

            Console.WriteLine("Writing like this:");
            _excelentPupil.Write();
            _goodPupil.Write();
            _badPupil.Write();

            Console.WriteLine("Relax like this:");
            _excelentPupil.Relax();
            _goodPupil.Relax();
            _badPupil.Relax();
            */
            /////Задача№7//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
            Plane _plane = new Plane();
            Ship _ship = new Ship();
            Car _car = new Car();
            _plane.Hight = 5;
            _plane.Quality = 15;
            _plane.Price = 25;
            _plane.Speed = 35;
            _plane.Year = 1995;
            Console.WriteLine(_plane);
            */
            ////Задача№8/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
            int _key = 2;
            switch (_key)
            {
                case 1: DocumentWorker pdw = new ProDocumentWorker(); pdw.OpenDocument(); pdw.EditDocument(); pdw.SaveDocument() ; break;
                case 2: DocumentWorker edw = new ExpertDocumentWorker(); edw.OpenDocument(); edw.EditDocument(); edw.SaveDocument(); break;
                default: DocumentWorker ddw = new DocumentWorker(); ddw.OpenDocument(); ddw.EditDocument(); ddw.SaveDocument(); break;
            }
            */
            Console.ReadLine();
        }
    }
}
