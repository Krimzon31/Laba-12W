using System;

namespace Laba_12_W
{

    class EventDelegateClass
    {
        private string name;

        public delegate void EventDelegate(string txt);
        public EventDelegateClass(string name)
        {
            this.name = name;
        }
        public event EventDelegate Event; 
        public void RaiseMyEvent()
        { 
            if (Event != null)
            {
                Event(name);
            }
        }
    }
    class KakoyToClass
    { 
        private string text;
        public KakoyToClass(string metodtext)
        {
            text = metodtext;
        }
        public void show(string objname)
        {
            Console.WriteLine("Объект, сгенерировавший событие: " + objname);
            Console.WriteLine("Сообщение: " + text);
        }
    }
    class Program
    {
        static void Main()
        {
            EventDelegateClass kakoyToOdject1 = new EventDelegateClass("KakoyToOdject1");
            EventDelegateClass kakoyToOdject2 = new EventDelegateClass("KakoyToOdject2");
           
            KakoyToClass KakoyToClassObject = new KakoyToClass("KakoyToClassObject");

            kakoyToOdject1.Event += KakoyToClassObject.show;
            kakoyToOdject2.Event += KakoyToClassObject.show;

            kakoyToOdject1.RaiseMyEvent();
            Console.WriteLine();

            kakoyToOdject2.RaiseMyEvent();
            Console.WriteLine();
        }
    }
}
