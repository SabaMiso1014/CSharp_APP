// Hello World
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            // コンソールにHelloWorldと表示する。
            Console.WriteLine("Hello World!"); 
        }
    }
}

// 変数
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            // ------------値型------------
            // int(整数)
            int intNum = 2;
            // float(単精度浮動小数点)
            float floatNum = 1.234f;
            // double(倍精度浮動小数点)
            double doubleNum = 1.234;
            // bool(論理)
            bool boolVal = true;
            // char(文字)
            char c = 'a';
            // DateTime(日付)
            DateTime date;

            // ------------参照型------------
            // String(文字列)
            String str = "hoge";
            // 配列型
            int[] array; 
        }
    }
}

// 四則演算
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            // num = 2
            int num = 1 + 1;

            // num2 = 0
            int num2 = 1 - 1;

            // num3 = 3
            int num3 = 1 * 3;

            // 小数点以下切り捨て
            int num4 = 1 / 2;

            // floatなので小数点が扱える
            float num5 = 1 / 2;

            // 余りの数の求め方
            int num6 = 10 % 3;

            // 複合代入演算子
            num6 += 1;
            num6 -= 1;
        }
    }
}

// インクリメント・デクリメント
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            int i = 10;
            int k = 10;
            // 11が表示される
            Console.WriteLine(++i);
            // 10が表示される
            Console.WriteLine(k++);
            // 以降は k の値は11となっている
        }
    }
}

// アクセス修飾子
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            // 誰からも見えるし、誰でも使える
            public GetHP();
            public GetName();
            // このCharacterクラスの内部処理内でしか見えないし、使えない
            private void SetRotation();
        }
    }
}

// 名前空間
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassA
{
    public class Sato
    {
        public void Hello()
        {
            Console.WriteLine("My name is Sato! My class is A!");
        }
    }
}

namespace ClassB
{
    public class Sato
    {
            Console.WriteLine("My name is Sato! My class is B!");
    }
}

// 配列
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            // 普通の配列
            // 変数 = new 型名[配列の長さ]
            int array = new int[3];

            // 配列の要素ごとに値を代入
            array[0] = 5;
            array[1] = 10;

            // 初期データを指定 
            int array2 = new int[] { 0, 5, 10 };
            string[] cats = {"黒猫", "三毛猫", "ぶち", "はちわれ"};

            // ジャグ配列での初期化
            int[][] jagged = new int[][]
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6, 7}
            };

            // 四角配列での初期化
            int[,] grid = new int[,]
            {
                {1, 1, 1},
                {2, 2, 2},
                {3, 3, 3}
            };
        }
    }
}

// if文
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            bool isDead = Hero.IsDead();

            // もし勇者が死んでいたら
            // if(isDead)でも可
            if(isDead == true)
            {
                // Gameover処理
            }
            else
            {
                // 生きていたらClear処理
                // else if(isDead != true)　や
                // else if(!isDead)　とも書ける
            }
        }
    }
}

// for文
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            int[] array = { 0, 5, 10 };
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == 0)
                {
                    // continueを書くとここでループ処理が中断され、変数の更新後ループ処理の頭から再度開始します
                    continue;
                }

                array[i] += 10;
            }
        }
    }
}

// while文
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            int i = 0;
            while(i < 10)
            {
                ++i;
                // 何か処理

                if(i == 5)
                {
                    // while文から抜ける
                    break;
                }
            }
        }
    }
}

// foreach文
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            int[] array = { 0, 5, 10 };
            // foreach(変数宣言 in ループ処理したい配列)
            foreach (int num in array)
            {
                num += 10;
            }
        }
    }
}

// enum文
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            enum DayOfWeek {
                Sunday,
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday
            }
        }
    }
}

// switch文
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            switch (obj) {
                case int n:
                    // 整数だった場合の処理
                    break;
                case string s:
                    // 文字列だった場合の処理
                    break;
                case bool b:
                    // boolだった場合の処理
                    break;
                default:
                    // その他の場合の処理
                    break;
            }
        }
    }
}

// 例外処理
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    public class Program {
        public static void Main(string[] args) {
            throw new Exception("not found!");
            try {
                // 例外が発生する可能性のある処理
            }
            catch(Exception e) {
                // 例外に対応した処理
            }
        }
    }
}
