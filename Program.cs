
//Console.WriteLine("Hello, World!");
//int a = 5;
//Console.WriteLine(a);

class Execute
{
    public static void Main(string[] args)
    {


        PolymorphismConcept.A a1 = new PolymorphismConcept.A();
        a1.Call();
        a1 = new PolymorphismConcept.B();
        a1.Call();
        a1 = new PolymorphismConcept.C();
        a1.Call();

        /*
         * This is not posible as class B is not a super class
         * 
         * PolymorphismConcept.B b1 = new PolymorphismConcept.B();
        b1.Call();
        b1 = new PolymorphismConcept.A();
*/



        /*
                //Interface
                InterfaceConcept.child c = new InterfaceConcept.child();
                c.CallA();
                c.CallB();
                */

        /*// Abstract Class and Method
        AbstractCAM.AbstractClassAndMethod am = new AbstractCAM.AbstractClassAndMethod();
        am.Pout();
*/

        /* // Method Overriding

         MethodOverridingConcept.MethodOverriding1 m = new MethodOverridingConcept.MethodOverriding1();
         m.Add();
         MethodOverridingConcept.MethodOverriding2 m1 = new MethodOverridingConcept.MethodOverriding2();
         m1.Add();*/

        /* //SuperCallingConstructor

         SuperCallingConstructorSample.SubConstructor3 s = new SuperCallingConstructorSample.SubConstructor3();
        */


        /*
        // Inheritance Concept

        InheritanceConcept.InheritanceSingleLevel1 I = new InheritanceConcept.InheritanceSingleLevel1();
        I.call1();
        I.call2();
        InheritanceConcept.InheritanceMultileLevel M = new InheritanceConcept.InheritanceMultileLevel();
        M.call1();
        M.call2();
        M.call3();
        InheritanceConcept.InheritanceHybridLevel H1 = new InheritanceConcept.InheritanceHybridLevel();
        H1.call1();
        H1.call4();
        InheritanceConcept.InheritanceHybridLevel1 H2 = new InheritanceConcept.InheritanceHybridLevel1();
        H2.call1();
        H2.call5();*/



        /*// Constructor-Overloading 
        ConstructorSample.Constructor c = new ConstructorSample.Constructor();
        ConstructorSample.Constructor c1 = new ConstructorSample.Constructor(5);
        ConstructorSample.Constructor c2 = new ConstructorSample.Constructor("hanuman");
        ConstructorSample.Constructor c3 = new ConstructorSample.Constructor(5.22);
        ConstructorSample.Constructor c4 = new ConstructorSample.Constructor("Kumar",63);
        //this calling constructor
        ConstructorSample.ConstructorwithCalling d = new ConstructorSample.ConstructorwithCalling("Ravi");
*/


        /*
                //Static and Non staic method

                Statickeyword.StaticAndNonStatic.Staticmethod("Seetha");

                Statickeyword.StaticAndNonStatic.b = 1;
                Console.WriteLine(Statickeyword.StaticAndNonStatic.b);

                Statickeyword.StaticAndNonStatic.Staticmethod("Geetha");

                Statickeyword.StaticAndNonStatic nsm = new Statickeyword.StaticAndNonStatic();

                Console.WriteLine(nsm.s1);
                nsm.s1 = "Ravi";
                nsm.Nonstaticmethod(23.56);
                */


        /* // method overloading
         OverLoading.MethodOverLoading mo = new OverLoading.MethodOverLoading();
         mo.Test();
         mo.Test(5);
         mo.Test("RaviKumar");
         mo.Test(6, "Hanuman");
         mo.Test("Jai", 10);*/




        //variables
        /*Sample1.Fan f = new Sample1.Fan();
        f.Method_fan();
        f.a = 1;
        Console.WriteLine(f.a);

        Sample2.Fan f2 = new Sample2.Fan();
        int result = f2.Method_fan();
        f2.b1 = "HI";
        Console.WriteLine(f2.b1);
        Console.WriteLine(result);*/
    }



}



