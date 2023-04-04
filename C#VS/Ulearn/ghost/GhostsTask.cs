using System;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Text;

namespace hashes
{
    public class GhostsTask :
        IFactory<Document>, IFactory<Vector>, IFactory<Segment>, IFactory<Cat>, IFactory<Robot>,
        IMagic
    {
        static byte[] data = new byte[4];

        static Encoding Encodingencoding;
        Document doc = new Document("Test", Encodingencoding, data);

        public Document Create()
        {
            return doc;
        }   

        public Vector vectors = new Vector(22, 12);


        public void DoMagic()
		{
            //VECTOR        DONE
            vector.Add(vectors);
            //CAT           DONE
            cat.Rename("durka");
            //ROBOT
            Robot.BatteryCapacity = 1000;
            robot.Move(1, 1);
            //DOCUMET
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)i;
            }
            data[2] = 4;
            //SEGMENT
            end = new Vector(111,1111111111111);

        }

        // Чтобы класс одновременно реализовывал интерфейсы IFactory<A> и IFactory<B> 
        // придется воспользоваться так называемой явной реализацией интерфейса.
        // Чтобы отличать методы создания A и B у каждого метода Create нужно явно указать, к какому интерфейсу он относится.
        // На самом деле такое вы уже видели, когда реализовывали IEnumerable<T>.
        private Vector vector = new Vector(1, 2);
		Vector IFactory<Vector>.Create()
		{
            return vector;
		}

        private Segment segment;
        private Vector start = new Vector(1,2);
        private Vector end = new Vector(0, 0);

		Segment IFactory<Segment>.Create()
		{
            return segment = new Segment(start, end);
		}

        private Cat cat = new Cat("Sofa", "bredd", new DateTime(1, 1, 1));

        Cat IFactory<Cat>.Create()
        {
            
            return cat;
        }

        private Robot robot = new Robot("11");

        Robot IFactory<Robot>.Create()
        {
            return robot;
        }

        // И так даллее по аналогии...
    }
}