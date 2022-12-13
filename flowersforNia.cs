using System;

class Program
{
    static void Main(string[] args)
    {

        //string data for flower 1
        string flower1 = @"
                        H           H   H   H           H
                                H   H       H   H   H   H       H   H
                                    H   H       H   H   H       H   H
                        H       H   H       H   H   H   H       H   H       H
                        H   H       H   H       H   H   H       H   H       H   H
                        H   H   H   H   H       H   H       H   H   H   H   H
                        H   H       H   H   H       H       H   H   H       H   H
                        H   H       H   H   H           H   H   H   H   H   H
                        H   H   H       H   H   H       H   H   H   H       H   H
        @               H   H   H       H   H   H   H   H   H   H       H   H
            @ @          H   H   H   H       H   H   H   H   H   H       H   H   H
            @ @         H   H   H   H   H   H   H   H   H   H   H       H   H
                @ @ @        H   H   H       H   H   H   H   H   H       H   H   H
                @ @     H   H   H   H       H   H   H   H   H       H   H   H
                    @ @ @    H   H   H           H   H   H   H       H   H   H    @ @
                    @ @   H   H   H   H   @   H   H   H           H   H   H   @ @ @ @ @
                    @ @      H   H   H    @ @    H   H           H   H   H    @ @ @   @ @
                @ @ @   H   H   H   H   @ @     H       H   H   H   H     @ @ @
                    @ @  H   H   H   H      @ @          H   H   H   H   H    @ @ @
                    @     H   H   H   H   @ @ @   H   H   H   H   H   H     @ @ @
                        H   H   H   H      @ @      H   H   H   H   H   H    @ @
                        H   H   H   H     @ @       H   H   H   H   H     @ @ @
                @ @ @        H   H   H   H    @ @    H   H   H   H   H   H    @ @
            @ @ @ @ @ @       H   H   H     @ @ @     H   H   H   H   H     @ @ @
            @ @     @ @ @        H   H   H    @ @ @      H   H   H   H      @ @ @
            @       @ @ @ @   H   H   H   H   @ @ @   H   H   H   H   H   @ @ @
                        @ @ @    H   H   H    @ @ @ @    H   H   H   H    @ @ @ @
                        @ @ @     H   H   H   @ @ @   H   H   H   H     @ @ @
                            @ @ @    H   H    @ @ @ @    H   H   H      @ @
                            @ @     H   H   @ @ @ @     H   H       @ @ @
                                @ @ @    H    @ @ @ @ @  H          @ @ @
                                @ @ @       @ @ @ @ @ @   @ @ @ @ @ @ @
                                @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @ @
                                    @ @ @ @ @ @ @ @ @ @ @ @ @ @ @
                                        @ @ @ @ @ @ @ @ @ @
                                            @ @ @ @ @ @
                                            @ @ @ @ @
                                                @ @ @
                        @ @ @                   @ @ @
                        @ @ @ @ @ @             @ @ @
                        @ @ @ @ @ @ @         @ @ @
                        @ @ @ @ @ @ @       @ @ @
                            @ @ @ @ @ @ @     @ @ @   @ @ @ @ @
                            @ @ @ @ @   @ @ @ @ @ @ @ @ @ @ @ @ @
                                    @ @   @ @ @     @ @ @ @ @ @ @ @ @
                                    @ @ @ @       @ @ @ @ @ @ @ @ @
                                    @ @ @ @             @ @ @ @ @
                                @ @ @ @
                            @ @ @ @
        ";

//string data for second flower
        string flower2 = @"
                %%%%%%
                    %%%%%% 
                    &&%%%%%
                    '   %%%%%
            	    '    %%%%
                        ''      %%%%
                        ' '       %%%%
                        '  '        %%%%
            	'    '         %%%%
            	'  ~~   '          %%%%
            	' ~~ ~~  '	        %%%%
            ' ~~~  ~~~  '             %%%%
                ' ~~~~~  ~~~~ '              %%%%
                ' ~~~~~ ~~~~~  '              %%%%
            ' ~~~~~  ~~~~  '	         &&&&&&&
            `  ~~~  ~~~  '	       {{}}{{}}{{}}
            `  ~~~ ~~  '                /         \
                `  ~~~  '                /     /\      \
                `    '                /                 \
            `'                /       /    \        \
                                /                         \
            	            /         /        \         \
                                /                              \
                                \       /   \      /    \      /
                                ....        ....        ....
            	                        ||     \\
             	        	        ||      \\
               	        	        ||       \\
                                    o o       oo        o o
                                    oo        oo         oo
                                    o         o          o
        ";

//string data for flower 3
        string flower3 = @"
            __ .---.
                    __ /  `  .-.7,--.
                    /  `. .-''. -,  , \
                    '--.-    -;   | ) /
                    ,` /   \ ,_) /   '-.
                    /  (  (  |   /  .' ) \
                    '.  `--,/   .---' ,-.|
                    `--.  / '-, -' .'
                    .==,=; `-,.;--'
                    / ,'  _;--;|
                    /_...='    ||
                        jgs || .==,=.
                            ||/    '.\
                            ,||`'=...__\
                            ||
                            ||
                            ||,
                            ||
                            ||
                            ||

        ";

//string data for flower 4
        string flower4 = @"
                .=====__
                            /==Z' .===_ ~~=,_===\
                            _/  |   |    YZ, `\,   ~\
                            |   |   | _/=j'\   !,   d
                    __====_|   |   b/    V`;  /'  .M ,
            `5\==/~~       W,  t   d+,  .D4| /   /'|/~~~\=__     .-
            `\            t~\ |   |t`~~T/'|Z  :/  |        ~~\=/V
                \           |  \4,  | ~/~' :Z  -!   |             |
                \,      /\__|   \\.!     :XG   \   / ._,       ./'
                `L    |    ~;    V;  _//' |    \ .f~' `~;    .b_
                ./ \\__JL    `;    Y7~     |    / /     d   //'  \,
                .!       `D\,  `\,   |     .!   .t/    .(_/=~      \
                /         `;`~~~=+=qLb,   jK_L==f'    j''          `;
            ./          .(r,        `~\5'   ~\\,._r/              |
            ~=m!         ./D' `\,          \,     !G~                 t
            ~==___===/'/   .!`\__       /! __=~\\~=_                TG=
                        |   .|     ~\=\=r@/~5 \   !,  ~=_,        __//'
                        |./~V           ||  `| \,  t     ~~~~\==~~
                        t|  |           | |  |  !\, \=_,
                        !   t          .! !, \    `\/~~~
                            |          /   !\/\
                            `;       ./      `~-
                            t      .!
                            N,  ./'
                                `\/'";

//string data for flower 5
        string flower5 = @"
            .@.                                    .
                        @m@,.                                 .@
                        .@m%nm@,.                            .@m@
                    .@nvv%vnmm@,.                      .@mn%n@
                    .@mnvvv%vvnnmm@,.                .@mmnv%vn@,
                    @mmnnvvv%vvvvvnnmm@,.        .@mmnnvvv%vvnm@
                    @mmnnvvvvv%vvvvvvnnmm@, ;;;@mmnnvvvvv%vvvnm@,
                    `@mmnnvvvvvv%vvvvvnnmmm;;@mmnnvvvvvv%vvvvnmm@
                    `@mmmnnvvvvvv%vvvnnmmm;%mmnnvvvvvv%vvvvnnmm@
                        `@m%v%v%v%v%v;%;%;%;%;%;%;%%%vv%vvvvnnnmm@
                        .,mm@@@@@mm%;;@@m@m@@m@@m@mm;;%%vvvnnnmm@;@,.
                    .,@mmmmmmvv%%;;@@vmvvvvvvvvvmvm@@;;%%vvnnm@;%mmm@,
                .,@mmnnvvvvv%%;;@@vvvvv%%%%%%%vvvvmm@@;;%%mm@;%%nnnnm@,
                .,@mnnvv%v%v%v%%;;@mmvvvv%%;*;*;%%vvvvmmm@;;%m;%%v%v%v%vmm@,.
            ,@mnnvv%v%v%v%v%v%v%;;@@vvvv%%;*;*;*;%%vvvvm@@;;m%%%v%v%v%v%v%vnnm@,
            `    `@mnnvv%v%v%v%%;;@mvvvvv%%;;*;;%%vvvmmmm@;;%m;%%v%v%v%vmm@'   '
                    `@mmnnvvvvv%%;;@@mvvvv%%%%%%%vvvvmm@@;;%%mm@;%%nnnnm@'
                    `@mmmmmmvv%%;;@@mvvvvvvvvvvmmm@@;;%%mmnmm@;%mmm@'
                        `mm@@@@@mm%;;@m@@m@m@m@@m@@;;%%vvvvvnmm@;@'
                        ,@m%v%v%v%v%v;%;%;%;%;%;%;%;%vv%vvvvvnnmm@
                    .@mmnnvvvvvvv%vvvvnnmm%mmnnvvvvvvv%vvvvnnmm@
                    .@mmnnvvvvvv%vvvvvvnnmm'`@mmnnvvvvvv%vvvnnmm@
                    @mmnnvvvvv%vvvvvvnnmm@':%::`@mmnnvvvv%vvvnm@'
                    @mmnnvvv%vvvvvnnmm@'`:::%%:::'`@mmnnvv%vvmm@
                    `@mnvvv%vvnnmm@'     `:;%%;:'     `@mvv%vm@'
                    `@mnv%vnnm@'          `;%;'         `@n%n@
                        `@m%mm@'              ;%;.           `@m@
                        @m@'                 `;%;             `@
                        `@'                   ;%;.             '
        ";

        var key = new ConsoleKeyInfo();

        while (!System.Console.KeyAvailable && key.Key != ConsoleKey.Escape)
        {
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine();
            System.Console.Write("Enter a letter part of your name (quit = ESC): ");
            key = System.Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.N:
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine(flower1);
                    break;
                case ConsoleKey.I:
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine(flower2);
                    break;

                case ConsoleKey.A:
                    System.Console.ForegroundColor = ConsoleColor.DarkYellow;
                    System.Console.WriteLine(flower3);
                    break;

                case ConsoleKey.B:
                    System.Console.ForegroundColor = ConsoleColor.DarkCyan;
                    System.Console.WriteLine(flower4);
                    break;

                case ConsoleKey.W:
                    System.Console.ForegroundColor = ConsoleColor.DarkGray;
                    System.Console.WriteLine(flower5);
                    break;

                default:
                    if (System.Console.CapsLock && System.Console.NumberLock)
                    {
                        System.Console.WriteLine(key.KeyChar);
                    }
                    break;
            }
        }
    }
}