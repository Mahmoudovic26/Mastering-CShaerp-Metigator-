namespace CALinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var lesson1 = new YTVideo
            {
                Id = "YTV1",
                Title = "LinkedListAndHashSet",
                Duration = new TimeSpan(00, 48, 08)
            };

            var lesson2 = new YTVideo
            {
                Id = "YTV2",
                Title = "Variables",
                Duration = new TimeSpan(00, 38, 08)
            };
            var lesson3 = new YTVideo
            {
                Id = "YTV3",
                Title = "classes and oop",
                Duration = new TimeSpan(00, 55, 08)
            };

            var lesson4 = new YTVideo
            {
                Id = "YTV4",
                Title = "stack",
                Duration = new TimeSpan(00, 59, 59)
            };
            var lesson5 = new YTVideo
            {
                Id = "YTV5",
                Title = "queue",
                Duration = new TimeSpan(01, 59, 59)
            };
            LinkedList<YTVideo> yTVideos = new LinkedList<YTVideo>(new YTVideo[] {
                lesson1,
                lesson2,
                lesson3,
                lesson4,
                lesson5

            });
            /**
            playlist.AddAfter(playlist.First, lesson2);
            var node3 = new LinkedListNode<YTVideo>(lesson3);
            playlist.AddAfter(playlist.First.Next, node3);
            playlist.AddBefore(playlist.Last, lesson4);
            playlist.AddLast(lesson5);
            */
            LinkedList<YTVideo> playlist = yTVideos;
            print("C# from Zero to hero", playlist);
            System.Console.WriteLine("null");
        }
        static void print(string title, LinkedList<YTVideo> playlist)
        {
            System.Console.WriteLine($"┌{title}");
            foreach (var item in playlist)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("└");
            System.Console.WriteLine($"total: {playlist.Count} item(s)");
        }
    }
    class YTVideo
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public TimeSpan Duration { get; set; }

        public override string ToString()
        {
            //https://www.youtube.com/watch?v=BKYiNKfmuGk&list=PL4n1Qos4Tb6SWPbJNpiznp-Ok4A8J_23l&index=35
            //  https://www.youtube.com/watch?v=BKYiNKfmuGk&list=PL4n1Qos4Tb6SWPbJNpiznp-Ok4A8J_23l&index=35
            return $"├──{Title} ({Duration}) \n│\thttps://www.youtube.com/watch?v={Id}";
        }
    }
}