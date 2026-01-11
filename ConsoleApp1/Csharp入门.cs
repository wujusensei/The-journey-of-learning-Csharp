using System;

namespace TestWindowsForms
{
    internal class Csharp入门
    {
        [STAThread]
        static void Main()
        {

            #region 知识点一  控制台输入及输出
            // Console.WriteLine()————输出一行，结束时自动换行
            // Console.Write();————输出，结束时不自动换行
            // Console.ReadLine();————输入，以换行符结束
            // Console.ReadKey();————检测键盘，输入一个符号，只检测一次

            // Console.WriteLine("What the sport do you like?");
            // Console.Write("Please write down here:");
            // Console.ReadLine();
            // Console.WriteLine("haha me too!");

            // Console.WriteLine("hello");
            // Console.WriteLine("");
            // Console.WriteLine("hello");

            //    int a = 0;
            //    while (true)
            //    {
            //        a++;
            //        Console.ReadKey();
            //        Console.Write(a);
            //    }

            #endregion

            #region 知识点二  声明变量，及其初始化
            // 变量————存储不同类型的数据的容器

            // 变量类型 变量名 = 初始值；
            // int a=1;
            // 变量类型有14种
            // 变量名自定义，但要按照一定要求，此处不赘述
            // 初始值，必须和变量类型统一

            //变量类型有以下：
            // 1.有符号的整型变量————一定范围的整数
            // sbyte    -128~127
            // short    -32768~32767
            // int      -21亿~21亿
            // long     -9百万兆~9百万兆
            // long a = 10;
            // 通过+号实现拼接打印
            // Console.WriteLine("这个变量的值是"+a);

            // 2.无符号的整型变量
            // byte     0~255
            // ushort   0~65535
            // uint     0~42亿
            // ulong    0~1.8千万兆

            // 3.浮点数（小数）
            // float    存储7或8位有效数字，打印时四舍五入第7/8位后面的数
            // float f = 0.123456f;     声明时的浮点数默认是double类型的，因此初始化float类型的变量的时候后面要加一个f表明立场
            // double   存储15到17位有效数字，打印时四舍五入第15到17位后面的数
            // decimal  存储27或28位有效数字，不建议使用，所占内存过多
            // decimal de = 0.123456m;  同理，不过加的是m
            // 值得注意的是 对于过大的数，浮点数会以科学计数法来存储

            // 4.特殊类型
            // bool     仅有两种类型——true——false——代表真与假
            // bool b = true;   特别的，虽然逻辑上代表了1与0，但是声明时仍只能用true或者false声明而不能是1或0
            // char 用来存储单个字符的变量类型   字符类型
            // char c = 'a';虽然其值以ASCII码存储，但是声明时不能直接用数字声明
            // string   用来存储多个字符的变量类型   字符串类型  无上限
            // string str = "whdgabwnchwhhacjkndkcansd";

            // 推荐  整数用int 浮点数用float 字符串用string 真假判断或二选一用bool
            #endregion

            #region 知识点三 变量的本质

            // 1byte = 8bit
            // 1KB  = 1024byte
            // 1bit就是一个数字_0或1_，一个字节byte就是八个比特，我们说一个字节为八位
            // 整数
            // int sizesbyte = sizeof(sbyte);
            // Console.WriteLine("sbyte所占的字节数为:" + sizesbyte);
            // int sizeint = sizeof(int);
            // Console.WriteLine("int所占的字节数为:" + sizeint);
            // int sizeshort = sizeof(short);
            // Console.WriteLine("short所占的字节数为:" + sizeshort);
            // int sizelong = sizeof(long);
            // Console.WriteLine("long所占的字节数为:" + sizelong);
            // Console.WriteLine("********************************************************");
            // 注：无符号所占的字节数与相应的有符号变量是一样的

            // 浮点数
            // int sizefloat = sizeof(float);
            // Console.WriteLine("float所占的字节数为:" + sizefloat);
            // int sizedouble = sizeof(double);
            // Console.WriteLine("double所占的字节数为:" + sizedouble);
            // int sizedecimal = sizeof(decimal);
            // Console.WriteLine("decimal所占的字节数为:" + sizedecimal);
            // Console.WriteLine("********************************************************");

            // 特殊变量
            // int sizebool = sizeof(bool);
            // Console.WriteLine("bool所占的字节数为:" + sizebool);
            // int sizechar = sizeof(char);
            // Console.WriteLine("char所占的字节数为:" + sizechar);
            // int sizestring = sizeof(string);不可取——因为string类型变量大小可变；
            #endregion

            #region 知识点四 变量的命名规则
            // 1.不能重名
            // 2.不能以数字开头
            // 3.不能使用关键字开头
            // 4.不能有除了下划线以外的特殊符号

            // 建议————以对应意思的英文或者拼音命名
            // 不建议————无意义的命名，汉字命名

            // 常用命名法：
            // 驼峰命名法(多用于变量命名)————首字母小写，之后的单词的首字母大写，如：int thisIsMyname;
            // 帕斯卡命名法（多用于函数，类命名）————所有单词的首字母都大写，如：int ThisIsYourName;
            #endregion

            #region 知识点五 常量
            // 常量的关键字const
            // 声明的固定写法：
            // const 变量类型 变量名 = 初始值；
            // 如：const int i=20;

            // 常量的特点：
            // 1.必须初始化   如：const int i；不可取，无初始化
            // 2.不能被修改   如：const int i=10;i=20;不可取，不可更改
            // 作用：声明一些常用且不变的量
            #endregion

            #region 知识点六 转义字符
            // 转义字符是字符串的一部分  用来表示一些特殊含义的字符
            // 比如：在字符串中表现 单引号 双引号 引号 空行等等；

            // 固定写法为   \字符
            // 如下：
            // 单引号   \'
            // 双引号   \"
            // 换行     \n
            // 斜杠     \\
            // 制表符   \t
            // 光标退格 \b
            // 空字符   \0
            // 警报音   \a
            // string str = "\"ha\\h\'a\nha\"";
            // Console.WriteLine(str);

            // @是一个特殊的符号，其后方内容会被认为是纯文本，可用于取消转义字符
            // 如：
            // string str = @"哈哈哈\哈哈哈";
            // Console.WriteLine(str);
            // Console.WriteLine(@"\n\t");
            #endregion

            #region 知识点七 隐式转换
            // 类型转换就是不同类型间的转换
            // 隐式转换的基本规则->不同类型间的转换
            // 大范围装小范围

            // 如：
            // long l = 1;  int i = 1;
            // l = i;可行，因为让long类型的变量去装int类型的变量，大可装小（隐式转换）
            // i = l;不可行，因为让int类型的变量去装long类型的变量，小不可装大
            // 注：几乎所有的整型变量类型和浮点数变量类型在相同类型间的转换都符合以上条件，除decimal外，decimal无法进行隐式转换

            // 不同大类型间的转换
            // 有符号的数 绝对无法隐式转换为 无符号的数
            // 无符号的数 可以隐式转换为范围足够的 有符号的数
            // 如：int i=1;uint ui=1;byte b=1;
            // 其中 i=ui；是不行的，而 i=b; 是可以的；

            // 浮点数可以装任何类型的整数
            // 任何整数都不能存储浮点数
            // 任何其他类型的变量都不能隐式转换为char类型
            // 但char类型可以转换为int类型以上的整型变量和任何浮点数变量
            // string类型无法和任何其他类型隐式转换
            #endregion

            #region 知识点八 显示转换

            // 显式类型转换->手动转换 强制转换

            #region 其一 括号强转
            // 1.  括号强转
            // 作用：将高精度的类型强制转换为低精度
            // 语法：变量类型 变量名 = （变量类型） 变量；

            // 相同大类
            // 对整数而言,例:
            // int i=1;sbyte sb=1;
            // sb=i;是不可行的，因为高精度类型不能隐式转换为低精度
            // sb=(sbyte)i;是可行的，这属于强制类型转换
            // 但要注意，括号强转可能会导致范围问题造成的异常

            //另，浮点数间也可以强制类型转换，不过不会出现范围问题的错误，而是可能会导致精度的丢失

            // 对于浮点数与小数间的括号强转
            // 浮点数强制转换为小数为向下取整，整数转换为浮点数则无异常；

            // 其他整数类型虽不可隐式转换为char类型，但任可通过括号强转实现转换
            // 如：int i='A';char c=(char)i;

            //bool和string不支持用括号强转
            #endregion

            #region 其二 Parse法
            // 作用：把字符串类型转换为对应的类型
            // 语法：变量类型 .Parse("字符串")
            // 注意：字符串必须能够转成对应的类型且范围必须在这个变量能够存储的范围内 否则报错

            // 例：
            // string str = "1234";
            // int i = int.Parse(str);
            // double d = double.Parse("12345.1234");
            #endregion

            #region 其三 Convert法
            // 作用：更准确地将各个类型之间进行相互转换
            // 语法：Convert.To目标类型（变量或常量）     后转给前
            // 注意：填写的变量或常量必须合法且在范围内 否则出错

            // 字符串转 （该字符串必须合法）
            // int a = Convert.ToInt32("12");

            //值得一提的是，Convert在转换的时候拥有更高的精度，对于浮点数会自动四舍五入
            // 如：
            //int a = Convert.ToInt32(1.5432f);
            //Console.WriteLine(a);

            // 对于bool类型变量，会默认false为0，true为1；
            // 例：int a =Convert.ToInt32(true);
            // Console.WriteLine(a);

            // 每一个类型都有对应的Convert中的方法
            // sbyte sb = Convert.ToSByte("1");
            // short s = Convert.ToInt16("1");
            // int i = Convert.ToInt32("1");
            // long l = Convert.ToInt64("1");
            // byte b = Convert.ToByte("1");
            // ushort us = Convert.ToUInt16("1");
            // uint ui = Convert.ToUInt32("1");
            // ulong ul = Convert.ToUInt64("1");
            // float f = Convert.ToSingle("1.23");
            // double d = Convert.ToDouble("1.23");
            // decimal m = Convert.ToDecimal("1");
            // bool bo = Convert.ToBoolean("true");
            // char c = Convert.ToChar("A");
            // string str = Convert.ToString(12345);
            #endregion

            #region 其四 其他类型转string
            // 作用：拼接打印
            // 语法：变量.ToString();
            // string str6 ="123123"+1+ true.ToString();
            // Console.WriteLine(str6);

            // 实际上，当我们进行字符串拼接的时候，就自动会调用ToString 转为string
            #endregion
            #endregion

            #region 知识点九 异常捕获
            // 作用
            // 对于string str = Console.ReadLine();
            //     int i = int.Parse(str);而言，读入的字符串的字面量必须符合int类型，不然程序就会出错
            // 异常捕获的作用就是当出现错误的时候，防止程序卡死

            // 基本语法
            // 必备部分
            // try
            // {
            // 希望进行异常捕获的代码块放到try中
            // 如果try{}中的代码报错了，不会让程序卡死
            // 如果出现错误，则try中的内容执行到出现错误的地方就打止，后面的内容被跳过
            // }
            // catch//(Exception e)
            // {
            // 如果出错了，会执行catch中的代码，来捕获异常
            // (Exception e)可以通过e得到具体的报错信息
            // }
            // 可选部分
            // finally
            // {
            // 最后执行的代码
            // 不管有没有出错都会执行其中的代码
            // }

            // 实践一下
            // try
            // {
            //    string str=Console.ReadLine();
            //    int i = int.Parse(str);
            //    Console.WriteLine(i);
            // }
            // catch
            // {
            //    Console.WriteLine("您输入的不是一个整数，请重新输入数字");

            // }
            // finally
            // {
            //    Console.WriteLine("执行完毕");
            // }
            #endregion

            #region 知识点十 运算符

            #region 其一 算数运算符
            // 算数运算符是用于数据类型变量计算的计算符
            // 它的返回值是数值

            // 赋值运算符
            // =
            // 将右侧的值赋给左边的变量
            // 如：int number=10086;

            // 算数运算符 优先级高于赋值运算符
            // + - * / %
            // 注意：整型变量做除法会丢失小数点后的小数（向下取整）
            // 为解决该问题，可用  float f = 1f*2;或double d =1.0 * 2;
            // 值得一提的是，取余运算符%仅可用于整型变量间的运算

            // 复合运算符 *= /= %= += -=
            // a*=a+1相当于a=a*(a+1);

            // 自增运算符  -- ++
            // a++  ->  先用在加
            // ++a  ->  先加再用

            #endregion

            #region 其二 字符串拼接
            // 对string来说，+并不是用来计算数学运算的，其作用是拼接
            // 如：
            // string str = "123";
            // str+=""+1+2+3+4;   ->   "1231234"
            // str+=1+2+""+3+4;   ->   "123334"
            // 拼接时若字符串加入了计算会默认将数字转换为字符串的形式进行拼接，但若按计算的顺序来的时候没有字符串，数字间的计算依旧会进行，如上，所以运算符的顺序很重要！！
            // str += "456";

            // 字符串拼接方式 2
            // 固定语法
            // string.Format("待拼接内容"，内容1，内容2，......);
            // 拼接中的固定规则：
            // 想要被拼接的内容用占位符来替代{数字} 数字：0~n;
            // 如：
            // string str = string.Format("我是{0}，今年{1}岁，我想要{2}", "Lethe", "18", "学习Csharp语言");
            // Console.WriteLine(str);

            // 控制台打印
            // 控制台打印默认使用Format相同方法，即
            //string str1 = "Lethe";
            //Console.WriteLine("我是{0}，今年{1}岁了，我的爱好是{2}",str1,18,"打游戏");

            //注：后面拼接的内容必须多余占位符所指的最大位数，不然会报错（少则无碍）
            #endregion

            #region 其三 条件运算符
            // 条件运算符是用来比较两个常量或变量的运算符
            // >  <  >=  <=  ==  !=
            // 固定写法：左边内容  条件运算符  右边内容
            // 条件运算符返回的结果是一个bool值，成立为true，不成立为false；
            // bool result = 1 < 2;
            // Console.WriteLine(result);

            // 条件运算符的优先级低于算数运算符，但高于赋值运算符
            // int a=4,6=2;bool result = a+3<b-2;

            // 不可连续使用来进行形如1<a<3;这样的范围比较；

            // 所有的整型变量和浮点数变量间可以随意进行比较
            // 而bool char string只能进行同类型间的==和！=比较
            #endregion

            #region 其四 逻辑运算符
            // 对bool类型 进逻辑运算
            // &&
            // 有假为假，同真为真

            // ||
            // 又真为真，同假为假

            // !
            // 真为假，假为真

            // 逻辑运算符（除！）优先级低于 条件运算符 和 算术运算符,,,！的优先级较高
            // 逻辑运算符间优先级为 ! > && > ||

            // 逻辑运算符的短路规则：
            // 只要逻辑与或逻辑或的左边满足了条件，右侧内容就不会计算
            #endregion

            #region 其五 位运算符
            // 位运算符  主要用数值类型进行计算的
            // 将数字视作二进制，再进行位运算

            // 位与  &
            // 对两个二进制数进行位运算，有0则0;
            // 如  int a=1;-> 001
            // int b=5;    -> 101
            // int c=a&b;  -> 001   ->c==1;

            // 位或  |
            // 对两个二进制数进行位运算，有1则1；
            // 如  int a=5;->0101
            // int b=10;   ->1010
            // int c=a|b;  ->1111  ->c==15;

            // 异或  ^
            // 对两个二进制数进行位运算，相同为0，不同为1
            // 如 int a=5;->0101
            // int b=15;  ->1111
            // int c=a^b; ->1010  ->c==10;

            // 位取反  ~
            // 对一个二进制数进行位运算，将它的1变为0，0变为1；
            // 如：int a=5;->0000 0000 0000 0101
            // ***Console.WriteLine(~a);  ->1111 1111 1111 1010  -> ~a==-6***重要！！***

            // 左移与右移  <<  >>
            // 对一个二进制数进行位运算，让它的所有位进行左移或右移
            // 如： int a=5;->0101
            // a<<=1;      ->1010  ->a==10
            // 可以理解为  左移几位是右边加几个零  右移几位是在右侧删几个数且左侧补上与符号位相同的数
            #endregion

            #region 其六 三目运算符
            // 套路：三个空位，两个符号
            // 固定语法：空位    ？空位                  ：空位                   ；
            // 关键信息：bool类型？bool类型为真时返回的内容：bool类型为假时返回的内容；
            // 例：bool bo = false;
            // string str = bo ? "条件为真" : "条件为假";
            // Console.WriteLine(str);
            #endregion

            #endregion

            #region 知识点十一 条件语句分支
            // 让顺序执行的代码产生分支

            #region if语句
            // 作用：满足条件时 执行代码块内语句
            // 语法：if(bool类型值)
            // {
            //      代码块内内容，满足条件时要执行的语句
            // }
            // if语句可以无限嵌套使用

            #region if-else语句
            // 作用：满足条件时 执行一个代码块内内容，否则执行另一代码块内内容
            // 语法：if(bool类型值)
            // {
            //      代码块内内容，满足条件时要执行的语句
            // }else
            // {
            //      代码块内内容，不满足条件时执行的语句
            // }

            #region if-else if-else if...语句
            // 作用：产生多条分支，优先选择满足条件的最先的一条执行代码块内内容，否则向下挑选分支执行
            // 语法：if(bool类型值)
            // {
            //      代码块内内容，满足条件时要执行的语句
            // }else if(bool类型值)
            // {
            //      代码块内内容，不满足上方条件但满足当前条件时要执行的语句
            // }else
            // {
            //      代码块内内容，不满足上方所有条件时执行
            // }

            #endregion
            #endregion

            #endregion

            #region switch语句
            // 作用：让顺序执行的代码产生分支，一般与枚举配合使用
            /* 语法：swtch(变量)
            {
                case 常量:
                    满足条件时执行的代码；
                    break;
                case 常量:
                    满足条件时执行的代码;
                    break;
                    ...case数量不限...
                default:(default可省略)
                    以上条件都不满足时执行的代码;
                    break;
            }*/
            // 注意，常量只能是一个具体的值，如字符串，浮点数，整数甚至是const int等，但不能是变量，也不能是一个范围；
            //case后的数字支持隐式转换，如float f=1.5f;可以在switch（f）下的case后写case 1；和case 1.5f;都可以

            #endregion

            #endregion

            #region 知识点十二 循环语句分支
            // 作用：让顺序执行的代码可以不停循环地执行某一代码块内的内容

            #region 其一 while语句
            // 语法：while(bool类型的值)
            // {
            //      只要满足条件就执行代码块内内容
            //      执行结束后判断是否满足while()里面的内容，若满足，则重复执行代码块内内容，若不满足，则跳出
            // }
            #endregion

            #region 其二 do while语句
            // 语法：do
            // {
            //      满足while()里面的内容会执行的代码
            //      与while基本无异，本质区别在于dowhile至少执行一次代码块内内容，无论是否满足条件；
            // }while(bool类型变量的值);
            #endregion

            #region 其三 for循环语句
            // 语法
            // for(循环开始前执行的内容;判断每次循环是否进行的条件;每次循环结束执行的内容)
            // {
            //      循环体内容;
            // }
            #endregion

            #region 其四 流程控制关键词
            // break;
            // 忽略循环的条件，直接跳出循环(跳到循环外)
            // continue;
            // 忽略后面的内容，进入下一次循环(跳到循环判定点)
            #endregion
            #endregion
        }
    }

    #region 算数函数 Calculator
    class Calculator
    {
        public int sum(int a, int b)
        {
            return a + b;
        }

        public void jian(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        //public void PrintXTo1(int x)
        //{
        //    for(int i=x;i>0;i--)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        public void PrintXTo1(int x)
        {
            if (x == 1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x);
                PrintXTo1(x - 1);
            }
        }
    }
    #endregion

}

