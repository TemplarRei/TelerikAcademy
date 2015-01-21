/*    Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©
  © ©
 ©   ©
© © © ©
Note: The © symbol may be displayed incorrectly at the console so 
you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.
NB! Before testing change Console font to Consolas from Right Click>Properties>Fonts.*/
using System;
using System.Text;
class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        char asterix = '\u00A9';
        Console.WriteLine("    {0}    \n   {0} {0} \n  {0}   {0} \n {0} {0} {0} {0}", asterix);
    }
}