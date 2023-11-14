﻿
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SelExamples;
GHPTests ghpTests = new GHPTests();
List<string>drivers=new List<string>();
//drivers.Add("Edge");
drivers.Add("Chrome");
foreach (var d in drivers)
{
    switch (d)
    {
        case "Edge":
            ghpTests.InitializeEdgeDriver();
            break;
            
        case "Chrome":
            ghpTests.InitializeChromeDriver();
                break;
            

    }

}
/*Console.WriteLine("1.Edge  2.Chrome");
int ch=Convert.ToInt32(Console.ReadLine());
switch(d)
{
    case 1:
       ghpTests .InitializeEdgeDriver();
        break;
        case 2:
        ghpTests .InitializeChromeDriver();   
        break;

}*/
try
{
    ghpTests.TitleTest();
    ghpTests.PageSourceandURLTest();
    ghpTests.GStest();
    ghpTests.GmailLinkTest();
    ghpTests.ImagesLinkTest();
    ghpTests.LocalizationTest(); 
    ghpTests.GappYouTubeTest();
}
catch (AssertionException)
{
    Console.WriteLine("Fail");
}
ghpTests.Destruct();

