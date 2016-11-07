using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    interface IPlayable
    {
        void Play();
        void Stop();
        void Pause();
    }
    interface IRecodable
    {
        void Pause();
        void Record();
        void Stop();
        }
        class Player : IPlayable, IRecodable
        {
        public void Play()
        {
            Console.WriteLine("Play in IP");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop in IP");
        }
        void IPlayable.Pause() { Console.WriteLine("Pause in IP"); }
        //
        void IRecodable.Record()
        {
            Console.WriteLine("Record in IR");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Stop in IR");
        }
        void IRecodable.Pause() { Console.WriteLine("Pause in IR"); }
       
    }
    class Progran
    {
       static  void Main()
        {
            Player pl = new Player();
            IPlayable IP = pl as Player;
            IP.Play();
            Console.ReadKey();
        }
    }
}
