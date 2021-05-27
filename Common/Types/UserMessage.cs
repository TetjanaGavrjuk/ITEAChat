using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common.SimpleTypes;

namespace Common.Types
{

    public interface IUserMessage
    {
        User GetUserFrom { get; }
        User GetUserTo { get; }
        //timstamp TimeStamp { get; }

        string GetText { get; }
       
        ConsoleColor  GetColor { get; }
        TextFormat GetTextFormat { get; }
     }

    public class UserMessage : IUserMessage
    {
        public User UserFrom;
        public User UserTo ;
        //timstamp TimeStamp;

        public string Text;
        public ConsoleColor Color;
        TextFormat TextFormat;

        public User GetUserFrom =>  this.UserFrom;

        public User GetUserTo => this.UserTo;

        public ConsoleColor GetColor => this.Color;

        public TextFormat GetTextFormat => this.TextFormat;

        public string GetText => this.Text;
    }
}
