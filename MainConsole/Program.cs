using System.Runtime.InteropServices.Marshalling;
using DailyDiary;
using MainConsole;
using System;
using Microsoft.IdentityModel.Tokens;

class Program
{
    static void Main()
    {
        DiaryLogic logic = new DiaryLogic();

        logic.SelectMenu();
    }
}
