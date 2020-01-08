using System;

namespace 外套娃巨大
{
    namespace 外套娃大
    {
        public class 套娃究极大
        {
            public class 套娃巨大
            {
                public 套娃巨大()
                {
                    void 套娃超大()
                    {
                        void 套娃大()
                        {
                            var 套娃中 = new Action(delegate
                            {
                                var 套娃小 = new Action(() =>
                                {
                                    var 套娃迷你 = new Action(() =>
                                    {
                                        throw new StackOverflowException("禁止套娃");
                                    });
                                    套娃迷你();
                                });
                                套娃小();
                            });
                            套娃中();
                        }

                        套娃大();
                    }

                    套娃超大();
                }
            }
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var 套娃 = new 外套娃巨大.外套娃大.套娃究极大.套娃巨大();
    }
}