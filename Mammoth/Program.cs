class Program{static void Main(){var s=@"class<Chair6>Quine<Powder><Day>{<Powder><Day><Chair3><Chair12>public<Chair16>void<Chair11>B(string<Chair9>s)<Powder><Day><Chair23>
<Chair3>{<Powder><Day><Chair16><Chair1><Chair6><Chair8>const<Chair24>string<Chair17>pre<Chair16>=<Chair7><Gondola>class<Chair15>Program{static<Chair17>void<Chair17>Main(){
var<Chair23>s=@\<Gondola><Gondola>;<Powder><Day><Chair3><Chair4><Chair10><Chair20>System.Console.Write(pre);<Powder><Day><Chair5><Chair20><Chair8><Chair20>int<Chair22>colu
mnNo<Chair14>=<Chair17>0;<Powder><Day><Chair1><Chair24><Chair20><Chair21>const<Chair2>int<Chair13>width<Chair13>=<Chair7>171;<Powder><Day><Chair24><Chair17><Chair10><Chair
11>int<Chair17>fi<Chair17>=<Chair12>pre.Length+1;<Powder><Day><Chair6><Chair9><Chair13><Chair5>columnNo<Chair9>=<Chair17>pre.Length;<Powder><Day><Chair10><Chair4><Chair23>
<Chair3>foreach(char<Chair24>c<Chair12>in<Chair16>s.ToCharArray())<Powder><Day><Chair2><Chair3><Chair6><Chair3>{<Powder><Day><Chair8><Chair14><Chair8><Chair24><Chair22><Ch
air20>if<Chair6>(c<Chair3>!=<Chair5>10<Chair11>&&<Chair23>c        <Chair10>!=<Chair23>13)<Powder><Day><Chair3><Chair12><Chair8><Chair2><Chair12><Chair9>{<Powder><Day><Cha
ir10><Chair9><Chair1><Chair15><Chair21><Chair21><Chair3><C         hair1>System.Console.Write(c);<Powder><Day><Chair22><Chair6><Chair21><Chair12><Chair8><Chair3><Chair4><C
hair9>if<Chair12>(++columnNo<Chair9>>=<Chair14>width)<Pow          der><Day><Chair8><Chair2><Chair5><Chair       7><Chair11><Chair5><Chair4><Chair21>{<Powder><Day><Chair24
><Chair8><Chair24><Chair16><Chair21><Chair17><Chair23><Ch           air13><Chair17><Chair4>columnNo<Ch          air1>=<Chair1>0;<Powder><Day><Chair4><Chair2><Chair8><Chair
5><Chair2><Chair23><Chair12><Chair20><Chair24><Chair3>Sy            stem.Console.WriteLine();<Powde            r><Day><Chair21><Chair17><Chair22><Chair2><Chair8><Chair5><C
hair5><Chair3>}<Powder><Day><Chair17><Chair16><Chair6><              Chair1><Chair14><Chair6>}<Po              wder><Day><Chair6><Chair15><Chair15><Chair5>}<Powder><Day><P
owder><Day><Chair15><Chair17><Chair8><Chair9>var<Chair               13>post<Chair5>=<Chair24>                new<Chair21>System.Text.StringBuilder();<Powder><Day><Chair2>
<Chair9><Chair20><Chair17>post.Append(<Gondola>\<Gondo               la>;var<Chair8>rx<Chair                  21>=<Chair21>new<Chair12>System.Text.RegularExpressions.Regex
(\<Gondola><Chair[0-9]*>\<Gondola>);var<Chair7>s2=rx.                 Replace(s.Replace(\<                   Gondola><Chair20>\<Gon         dola>,\<Gondola>\<Gondola>).Rep
lace(\<Gondola>\\r\<Gondola>,<Chair10>\<Gondola>\<Go                  ndola>).Replace(\<          G         ondola>\\n\<Gondola>,           <Chair20>\<Gondola>\<Gondola>).
Replace(\<Gondola><Gondola>);<Powder><Day><Chair13>        <          Chair2><Chair9>          <Ch          air10>post.Append(S            ystem.Text.Encoding.ASCII.GetStr
ing(System.Convert.FromBase64String(<Gondola>PFBvd        2R          lcj4=<Gondola          >)));         <Powder><Day><Chai             r22><Chair2><Chair24><Chair21>pos
t.Append(<Gondola>\<Gondola>,<Chair8>\<Gondola>\\        r\<           Gondola>)           .Repla          ce(\<Gondola><G                ondola>);<Powder><Day><Chair21><C
hair16><Chair10><Chair11>post.Append(System.Text        .Enc           oding.A          SCII.Get          String(System                  .Convert.FromBase64String(<Gondola
>PERheT4=<Gondola>)));<Powder><Day><Chair13><Ch        air9><           Chai          r10><Chair          22>post.Ap                    pend(<Gondola>\<Gondola>,<Chair8>\<
Gondola>\\n\<Gondola>).Replace(\<Gondola><Gond        ola>);<            P          owder><Day>          <Chair8><                      Chair17><Chair20><Chair7>post.Appen
d(System.Text.Encoding.ASCII.GetString(System        .Convert                     .FromBase64S           tring(             <          Gondola>PEdvbmRvbGE+<Gondola>)));<Po
wder><Day><Chair24><Chair8><Chair10><Chair4>        post.Appen                  d(<Gondola>\<G          ondo              la>         ,<Chair3>\<Gondola>\\\<Gondola>\<Gond
ola>),\<Gondola><Chair23>\<Gondola>);<Gondo        la>);<Powde                r><Day><Chair12          ><C             hair2         0><Chair6><Chair11>post.Append(<Gondol
a>var<Chair5>res=Microsoft.CSharp.CSharpCo        deProvider.C              reateProvider(\<G          o             ndola>C         Sharp\<Gondola>).CompileAssemblyFromSo
urce(new<Chair6>System.CodeDom.Compiler.C        ompilerParamet           ers()<Chair1>{<Chai                      r4>},<Ch         air7>new<Chair23>string[]<Chair4>{<Chai
r3>s2<Chair12>});var<Chair13>asy<Chair20        >=<Chair17>res.          CompiledAssembly;as                      y.GetType         (\<Gondola>Quine\<Gondola>).GetMethod(\
<Gondola>B\<Gondola>).Invoke(asy.Create        Instance(\<Gondol        a>Quine\<Gondola>),n                    ew<Chair11         >object[]{<Chair11>s<Chair23>});}}<Chair
23>/**********<Chair9>Mammoth<Chair23>        Mountain<Chair2>Quine<Chair10>in<Chair3>C#<Cha                  ir17>Versio          n<Chair20>6+<Chair9>-<Chair2>CC<Chair13>
BY-NC-SA<Chair22>4.0<Chair16>2019<Cha        ir1>-<Chair10>Jeff<Chair12>Donze<Chair16>jwdonz                e@gmail.com<C         hair5>*****************/<Gondola>);<Powde
r><Day><Chair15><Chair7><Chair8><Ch         air9>var<Chair6>postStringScript<Chair15>=<Chair               9>post.ToStri          ng();<Powder><Day><Chair5><Chair15><Chair
8><Chair4>var<Chair16>postStringScr        iptArray<Chair23>=<Chair4>postStringScript.Split('            .');<Powder><Da          y><Chair1><Chair3><Chair22><Chair4>for(in
t<Chair1>index<Chair17>=<Chair12>0        ;<Chair10>index<Chair16><<Chair3>postStringScriptArr         ay.Length;<Chair          2>index++)<Powder><Day><Chair13><Chair3><C
hair3><Chair1>{<Powder><Day><Chair       5><Chair12><Chair20><Chair5><Chair16><Chair15>var<Chai      r4>word<Chair8>=<C          hair17>postStringScriptArray[index];<Powde
r><Day><Chair6><Chair13><Chair9><C      hair3><Chair6><Chair10>var<Chair14>rem<Chair5>=<Chair12>columnNo<Chair1>+<Chai          r7>word.Length<Chair14>+<Chair12>1;<Powder>
<Day><Chair5><Chair23><Chair22><Ch      air17><Chair4><Chair20>if<Chair8>(rem<Chair16>><Chair12>width)<Powder><Day><Ch          air6><Chair17><Chair24><Chair5><Chair3><Cha
ir14>{<Powder><Day><Chair13><Chair     10><Chair24><Chair14><Chair12><Chair20><Chair4><Chair4>if<Chair8>(width<Chair11         >-<Chair17>columnNo<Chair5>>=<Chair22>4<Chai
r2>&&<Chair3>index<Chair21><<Chair11>postStringScriptArray.Length<Chair17>-<Chair7>1)<Powder><Day><Chair22><Chair10><          Chair23><Chair24><Chair12><Chair9><Chair14><
Chair1>{<Powder><Day><Chair4><Chair10><Ch                      air6><Chair6><Chair12><Chair15><Chair24><Chair15><Chai          r7><Chair1>System.Console.Write(<Gondola>/<G
ondola><Chair1>+<Chair10>new<Chair16>str                                      ing('*',<Chair14>width-columnNo-2)<Cha          ir6>+<Chair12><Gondola>/<Gondola>);<Powder><D
ay><Chair16><Chair11><Chair15><Chair10><Chair9><Chai                                       r6><Chair7><Chair22>}<Pow          der><Day><Chair6><Chair4><Chair12><Chair24><C
hair3><Chair3><Chair6><Chair4>System.Console.WriteLine();<Po                                             wder><Day>          <Chair24><Chair23><Chair5><Chair12><Chair7><Ch
air3><Chair12><Chair15>columnNo<Chair11>=<Chair17>0;<Powder><Day><Chair22>                                                   <Chair3><Chair6><Chair17><Chair13><Chair21>}<P
owder><Day><Chair23><Chair24><Chair15><Chair4><Chair23><Chair8>System.Console.Write(word                                    );<Powder><Day><Chair6><Chair12><Chair6><Chair4
><Chair7><Chair23>columnNo<Chair22>+=<Chair4>word.Length;<Powder><Day><Chair16><Chair16><Chair15><Chair1                    ><Chair24><Chair22>if<Chair4>(index<Chair13><<C
hair23>postStringScriptArray.Length<Chair15>-<Chair24>1)<Powder><Day><Chair4><Chair10><Chair13><Chair12><Chair6><C         hair5>{<Powder><Day><Chair6><Chair13><Chair5><Ch
air7><Chair4><Chair13><Chair20><Chair22>System.Console.Write(<Gondola>.<Gondola>);<Powder><Day><Chair8><Chair8><Chair13><Chair20><Chair11><Chair3><Chair15><Chair16>columnN
o++;<Powder><Day><Chair13><Chair24><Chair20><Chair11><Chair17><Chair1>}<Powder><Day><Chair9><Chair9><Chair8><Chair3>}<Powder><Day><Chair2><Chair17><Chair9><Chair20>System.
Console.WriteLine();<Powder><Day><Chair17><Chair22>}<Powder><Day>}<Powder><Day><Chair4>";var rx = new System.Text.RegularExpressions.Regex("<Chair[0-9]*>");var s2=rx./***/
Replace(s.Replace(" ","").Replace("\r", "").Replace("\n", "").Replace("<Powder>", "\r").Replace("<Day>", "\n").Replace("<Gondola>", "\"")," ");var res=Microsoft.CSharp.
CSharpCodeProvider.CreateProvider("CSharp").CompileAssemblyFromSource(new System.CodeDom.Compiler.CompilerParameters() { }, new string[] { s2 });var asy = res./**********/
CompiledAssembly;asy.GetType("Quine").GetMethod("B").Invoke(asy./*********************************************************************************************************/
CreateInstance("Quine"),new object[]{ s });}} /********** Mammoth Mountain Quine in C# Version 6+ - CC BY-NC-SA 4.0 2019 - Jeff Donze jwdonze@gmail.com *****************/
