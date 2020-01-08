using System;
using 外套娃超大.外套娃大.外套娃中.外套娃小.外套娃迷你;

namespace 外套娃超大
{
    namespace 外套娃大
    {
        namespace 外套娃中
        {
            namespace 外套娃小
            {
                namespace 外套娃迷你
                {
                    public class 套娃超大
                    {
                        public class 套娃大
                        {
                            public class 套娃中
                            {
                                public class 套娃小
                                {
                                    public class 套娃迷你
                                    {
                                        public 套娃迷你()
                                        {
                                            内套娃超大();
                                            void 内套娃超大()
                                            {
                                                内套娃大();
                                                void 内套娃大()
                                                {
                                                    内套娃中();
                                                    void 内套娃中()
                                                    {
                                                        内套娃小();
                                                        void 内套娃小()
                                                        {
                                                            内套娃迷你();
                                                            void 内套娃迷你()
                                                            {
                                                                throw new StackOverflowException("禁止套娃");
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        _ = new 套娃超大.套娃大.套娃中.套娃小.套娃迷你();
    }
}