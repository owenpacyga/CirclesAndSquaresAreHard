using System;

namespace CirclesAndSpheresAreHard
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declaring important variables 
            char whatDoWeKnow;
            float vauleOfPi;

            //This decides what pi is
            Console.WriteLine("What vaule do you want pi to be? 3.14, 3.141, etc.");
            string piVauleString = Console.ReadLine();
            bool didPiParse = float.TryParse((piVauleString), out vauleOfPi);

            if (didPiParse == false)
            {
                Console.WriteLine("You didn't input a number for the vaule of pi.");
                return;
            }

            //Deciding whether circles or shperes are being calculated
            Console.WriteLine("Do you want to claculate Spheres or Circles?");
            Console.Write("If you want to calculate circles, type 'C'. If you want to claculate spheres, type in 'S': ");
            string spheresOrCircle = Console.ReadLine();

            //cOrS stands for Circles Or Spheres
            char cOrS;
            cOrS = Convert.ToChar(spheresOrCircle);

            //Calculating circles
            if (cOrS == 'c' || cOrS == 'C')
            {
                Console.WriteLine("What do you know about the circle? If you know the diameter, enter D.");
                Console.WriteLine("If you know the radius, enter R. If you know the circumference, enter C.");
                Console.Write(" If you know the area, enter A: ");
                string rDC = Console.ReadLine();

                whatDoWeKnow = Convert.ToChar(rDC);

                //This code runs if user knows the radius
                if (whatDoWeKnow == 'R' || whatDoWeKnow == 'r')
                {
                    Console.WriteLine("What is the radius?");
                    string radiusString = Console.ReadLine();
                    bool didRadiusParse = float.TryParse((radiusString), out float radius);

                    if (didRadiusParse == false)
                    {
                        Console.WriteLine("You did not input a number for the radius.");
                        return;
                    }

                    float diameter = radius * 2;
                    float curcumference = 2 * vauleOfPi * radius;
                    float area = vauleOfPi * radius * radius;

                    Console.WriteLine("The diameter is " + diameter);
                    Console.WriteLine("The curcumference is " + curcumference);
                    Console.WriteLine("The area is " + area);
                }

                //This code runs in the user knows the diameter
                else if (whatDoWeKnow == 'D' || whatDoWeKnow == 'd')
                {
                    Console.WriteLine("What is the diameter?");
                    string diameterString = Console.ReadLine();
                    bool didDiameterParse = float.TryParse((diameterString), out float diameter);

                    if (didDiameterParse == false)
                    {
                        Console.WriteLine("You did not input a number for the diameter.");
                        return;
                    }

                    float radius = diameter / 2;
                    float curcumference = 2 * vauleOfPi * radius;
                    float area = vauleOfPi * radius * radius;

                    Console.WriteLine("The radius is: " + radius);
                    Console.WriteLine("The curcumference is: " + curcumference);
                    Console.WriteLine("The area is: " + area);
                }

                else if (whatDoWeKnow == 'C' || whatDoWeKnow == 'c')
                {
                    Console.WriteLine("What is the curcumference?");
                    string curcumferenceString = Console.ReadLine();
                    bool didCurcumferenceParse = float.TryParse((curcumferenceString), out float curcumference);

                    if (didCurcumferenceParse == false)
                    {
                        Console.WriteLine("You did not input a number for the curcumference.");
                        return;
                    }

                    float radius = curcumference / (2 * vauleOfPi);
                    float diameter = radius * 2;
                    float area = vauleOfPi * radius * radius;

                    Console.WriteLine("The radius is: " + radius);
                    Console.WriteLine("The diameter is: " + diameter);
                    Console.WriteLine("The area is: " + area);
                }

                else if (whatDoWeKnow == 'A' || whatDoWeKnow == 'a')
                {
                    Console.WriteLine("What is the area?");
                    string areaString = Console.ReadLine();
                    bool didAreaParse = float.TryParse((areaString), out float area);

                    if (didAreaParse == false)
                    {
                        Console.WriteLine("You did not input a number for the area.");
                        return;
                    }

                    //double theSquareRoot = Math.Sqrt(x); (example for how to use square root)
                    double radiusDouble = Math.Sqrt(area / vauleOfPi);
                    float radius = (float)radiusDouble;
                    float diameter = radius * 2;
                    float curcumference = 2 * vauleOfPi * radius;

                    Console.WriteLine("The radius is: " + radius);
                    Console.WriteLine("The diameter is: " + diameter);
                    Console.WriteLine("The curcumference is: " + curcumference);
                }

                else
                {
                    Console.WriteLine("You did not input a valid respose for what you know.");
                    return;
                }
            }

            //Calculating Spheres
            else if (cOrS == 's' || cOrS == 'S')
            {
                Console.WriteLine("What do you know about the sphere? If you know the radius, enter R.");
                Console.WriteLine("If you know the diameter, enter D. If you know the surface area, enter S.");
                Console.WriteLine("If you know the volume, enter V. if you know the curcumference, enter C.");
                string whatDoWeKnowString = Console.ReadLine();
                whatDoWeKnow = Convert.ToChar(whatDoWeKnowString);

                if (whatDoWeKnow == 'R' || whatDoWeKnow == 'r')
                {
                    Console.WriteLine("What is the radius?");
                    string radiusString = Console.ReadLine();
                    bool didRadiusParse = float.TryParse((radiusString), out float radius);

                    if(didRadiusParse == false)
                    {
                        Console.WriteLine("You did not input a valid responce.");
                        return;
                    }

                    float diameter = radius * 2;
                    float surfaceArea = 4 * vauleOfPi * radius * radius;
                    float volume = (4.0f / 3.0f) * vauleOfPi * radius * radius * radius;
                    float curcumference = 2 * vauleOfPi * radius;
                    //Put the .0f so then it knows to have decimal places, with the f to specify it as a float
                    Console.WriteLine("The diameter is: " + diameter);
                    Console.WriteLine("The surface area is: " + surfaceArea);
                    Console.WriteLine("The volume is: " + volume);
                    Console.WriteLine("The curcumference is: " + curcumference);
                }

                if (whatDoWeKnow == 'D' || whatDoWeKnow == 'd')
                {
                    Console.WriteLine("What is the diameter?");
                    string diameterString = Console.ReadLine();
                    bool didDiameterParse = float.TryParse((diameterString), out float diameter);

                    if (didDiameterParse == false)
                    {
                        Console.WriteLine("You did not input a vailid responce.");
                        return;
                    }

                    float radius = diameter / 2;
                    float surfaceArea = 4 * vauleOfPi * radius * radius;
                    float volume = (4.0f / 3.0f) * vauleOfPi * radius * radius * radius;
                    float curcumference = 2 * vauleOfPi * radius;
                    Console.WriteLine("The radius is: " + radius);
                    Console.WriteLine("The surface area is: " + surfaceArea);
                    Console.WriteLine("The volume is: " + volume);
                    Console.WriteLine("The curcumference is: " + curcumference);
                }

                if (whatDoWeKnow == 'S' || whatDoWeKnow == 's')
                {
                    Console.WriteLine("What is the surface area?");
                    string surfaceAreaString = Console.ReadLine();
                    bool didSurfaceAreaParse = double.TryParse((surfaceAreaString),out double surfaceArea);

                    if(didSurfaceAreaParse == false)
                    {
                        Console.WriteLine("You did not input a valid response.");
                        return;
                    }

                    double radius = Math.Sqrt(surfaceArea / (4 * vauleOfPi)); 
                    double diameter = radius * 2;
                    double volume = (4.0d / 3.0d) * vauleOfPi * radius * radius * radius;
                    double circumference = 2 * vauleOfPi * radius;
                    Console.WriteLine("The radius is: " + radius);
                    Console.WriteLine("The diameter is: " + diameter);
                    Console.WriteLine("The volume is: " + volume);
                    Console.WriteLine("The circumference is: " + circumference);
                }

                if(whatDoWeKnow == 'v'|| whatDoWeKnow == 'V')
                {
                    Console.WriteLine("What is the volume?");
                    string volumeString = Console.ReadLine();
                    bool didVolumeParse = double.TryParse((volumeString), out double volume);

                    if(didVolumeParse == false)
                    {
                        Console.WriteLine("You did not input a valid response");
                        return;
                    }

                    double radiusPartOne = 3 * (volume / (4 * vauleOfPi));
                    double radius = Math.Pow(radiusPartOne, (1.0 / 3.0));

                    double diameter = radius * 2;
                    double circumference = 2 * vauleOfPi * radius;
                    double surfaceArea = 4 * vauleOfPi * (radius * radius);

                    Console.WriteLine("The radius is: " + radius );
                    Console.WriteLine("The diameter is: " + diameter);
                    Console.WriteLine("The circumference is: " + circumference);
                    Console.WriteLine("The surface area is: " + surfaceArea);
                }

                if (whatDoWeKnow == 'c' || whatDoWeKnow == 'C')
                {
                    Console.WriteLine("What is the circumference?");
                    string circumferenceString = Console.ReadLine();
                    bool didCircumferenceParse = float.TryParse((circumferenceString), out float circumference);

                    if(didCircumferenceParse == false)
                    {
                        Console.WriteLine("You did not input a valid response");
                        return;
                    }

                    float radius = circumference / (2 * vauleOfPi);
                    float diameter = radius * 2;
                    double surfaceArea = 4 * vauleOfPi * (radius * radius);
                    double volume = (4.0d / 3.0d) * vauleOfPi * radius * radius * radius;

                    Console.WriteLine("The radius is: " + radius);
                    Console.WriteLine("The diameter is: " + diameter);
                    Console.WriteLine("The surface area is: " + surfaceArea);
                    Console.WriteLine("The volume is: " + volume);


                }
            }

            else
            {
                Console.WriteLine("You did not input a valid responce. ");
                return;
            }    
        }
    }
}
