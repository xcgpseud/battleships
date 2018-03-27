using Battleships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.ViewModels
{
    public class BoardViewModel
    {
        private Board board = new Board();

        public string BoardName
        {
            get
            {
                return board.Name;
            }
            set
            {
                board.Name = value;
            }
        }

        public string LblNameColour
        {
            get
            {
                if(board.Name == "test1")
                {
                    return "Blue";
                }
                else
                {
                    return "Red";
                }
            }
        }
    }
}
