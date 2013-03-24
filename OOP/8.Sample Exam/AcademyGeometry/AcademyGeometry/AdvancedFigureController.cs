using System;

namespace AcademyGeometry
{
    public class AdvancedFigureController:FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {
            switch (splitFigString[0])
            {
                case "circle":
                    {
                        Vector3D center = Vector3D.Parse(splitFigString[1]);
                        double radius = double.Parse(splitFigString[2]);
                        this.currentFigure = new Circle(center, radius);
                        break;
                    }
                case "cylinder":
                    {
                        Vector3D top = Vector3D.Parse(splitFigString[1]);
                        Vector3D bottom = Vector3D.Parse(splitFigString[2]);
                        double radius = double.Parse(splitFigString[3]);
                        this.currentFigure = new Cylinder(top, bottom, radius);
                        break;
                    }
            }
            base.ExecuteFigureCreationCommand(splitFigString);
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            {
                case "area":
                    {
                        var currentIAreaMeasurable = this.currentFigure as IAreaMeasurable;
                        if (currentIAreaMeasurable != null)
                        {
                            Console.WriteLine("{0:0.00}", currentIAreaMeasurable.GetArea());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "volume":
                    {
                        var currentIVolumeMeasurable = this.currentFigure as IVolumeMeasurable;
                        if (currentIVolumeMeasurable != null)
                        {
                            Console.WriteLine("{0:0.00}", currentIVolumeMeasurable.GetVolume());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "normal":
                    {
                        var currentIFlat = this.currentFigure as IFlat;
                        if (currentIFlat != null)
                        {
                            Console.WriteLine(currentIFlat.GetNormal().ToString());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
            }
            base.ExecuteFigureInstanceCommand(splitCommand);
        }
    }
}
