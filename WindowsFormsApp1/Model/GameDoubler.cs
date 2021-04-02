using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace WindowsFormsApp1.Model
{
    enum StatusGame
    {
        Win, Lose, Play
    }

    delegate void Action();

    class GameDoubler
    {
        private int _current;
        private int _count;
        private StatusGame _status;
        public Action action;

        public int Finish { get; private set; }
        Stack<GameHistory> history = new Stack<GameHistory>();

        public struct GameHistory
        {
            public int Count { get; set; }
            public int Current { get; set; }

            public GameHistory (int count, int current)
            {
                Count = count;
                Current = current;
            }
        }

        /// <summary>
        /// Текущее число
        /// </summary>
        public int Current => _current;

        /// <summary>
        /// Кол-во ходов
        /// </summary>
        public int Count => _count;


        public int Steps//минимальное кол-во шагов
        {
            get
            {
                int f = Finish;//50
                int i = 0;
                while (f != 1)
                {
                    if (f % 2 == 0) f = f / 2;
                    else f--;
                    //f = f % 2 == 0 ? f / 2 : f - 1;
                    i++;
                }
                return i+3;
            }
        }

        public string Status
        {
            get
            {
                switch (_status)
                {
                    case StatusGame.Play:
                        return "In game";
                    case StatusGame.Lose:
                        return "You are lose (:";
                    case StatusGame.Win:
                        return "You are win !!!";
                    default:
                        return "NA";
                }
            }
        }


        public void UpdateStatus()
        {
            if (_count < Steps && _current < Finish)
            {
                _status = StatusGame.Play;
            }
            else if(_count <= Steps && _current == Finish)
            {
                _status = StatusGame.Win;
            }
            else if (_count > Steps || _current > Finish)
            {
                _status = StatusGame.Lose;
            }           
        }

        public GameDoubler(int min, int max)
        {
            Finish = new Random().Next(min, max + 1);
            _current = 1;
        }

        public GameDoubler()
        {
            Finish = new Random().Next(10, 101);
            _current = 1;
            _status = StatusGame.Play;
        }

        public GameDoubler(int finish)
        {
            this.Finish = finish;
            _current = 1;
        }


        public void Plus()
        {            
            history.Push(new GameHistory(_count, _current));
            _count++;
            _current++;
            UpdateStatus();
            action();
            
        }

        public void Multi()
        {
            history.Push(new GameHistory(_count, _current));
            _count++;
            _current *= 2;
            UpdateStatus();
            action();            
        }

        public void Reset()
        {
            _count = 0;
            _current = 1;
            UpdateStatus();
            action();
            history.Clear();
        }

        public void Back()
        {
            if (history.Count != 0)
            {
                var h = history.Pop();
                _count = h.Count;
                _current = h.Current;
                UpdateStatus();
                action();
            }
     
        }

        public override string ToString()
        {
            return _current.ToString();
        }

    }
}
