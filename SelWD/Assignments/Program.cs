using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using Assignments;

/*AmazonTest amazonTest = new AmazonTest();
try
{
    amazonTest.Initialize();
    amazonTest.LocateTitleTest();
    //amazonTest.PageSourceandURLTest();
}
catch
{
    Console.WriteLine("Fail");
}
amazonTest.Destruct();
*/

NewBroswer newBroswer=new NewBroswer();
try
{
    newBroswer.InitializeChromeDriver();
    newBroswer.NavigatingToTest();
}
catch
{
    Console.WriteLine("Fail");
}
newBroswer.Destruct();