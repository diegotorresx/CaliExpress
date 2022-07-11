// See https://aka.ms/new-console-template for more information
using Business_Logic;

string pathInput = AppDomain.CurrentDomain.BaseDirectory + "Files\\Config.txt";

Dictionary<string, string> dictConfig = ReadFiles.ReadConfig(pathInput);