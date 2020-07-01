using System;
using System.Linq;

class MainClass {
  public static double CalculateBMI(double weight, double height)
  {
    double BMI = (weight*703)/(height*height);
    return BMI;
  }
  public static void BMIResults(double BMI)
  {
    var BMIResult = " ";
    if (BMI>29.9)
    {
      BMIResult = "Obese";
    }
    else if (BMI>24.9)
    {
      BMIResult = "Overweight";
    }
    else if (BMI>=18.5)
    {
      BMIResult = "Normal";
    }
    else if (BMI<18.5)
    {
      BMIResult = "Underweight";
    }
    Console.WriteLine (BMIResult);
    

  }
  public static void Main (string[] args) {
    
    double[] height = new double[10];
    double[] weight = new double[10];
    for(int pos=0; pos < height.Length; pos++)
    {
      Console.WriteLine ("Enter your height");
      height[pos]=Convert.ToDouble(Console.ReadLine());
      Console.WriteLine ("Enter your weight");
      weight[pos]=Convert.ToDouble(Console.ReadLine());
      double BMI = CalculateBMI(weight[pos],height[pos]);
      BMIResults(BMI);

    }



    /*Console.WriteLine ("Temperature in Fahrenheit");
    for(int pos=0; pos < temps.Length; pos++)
    {
      Console.WriteLine(temps[pos]*9/5 +32);
    }

    Console.WriteLine ("Average weekly temperature is " + temps.Sum()/7+ " degrees fahrenheit");*/
  }
}