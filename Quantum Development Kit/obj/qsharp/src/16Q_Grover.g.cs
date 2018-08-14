#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("_16Q_Grover", "Oracle (q : Qubit[]) : ()", new string[] { }, "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs", 145L, 7L, 5L)]
[assembly: OperationDeclaration("_16Q_Grover", "Diffusion (q : Qubit[]) : ()", new string[] { }, "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs", 4273L, 120L, 5L)]
[assembly: OperationDeclaration("_16Q_Grover", "Set (desired : Result, q1 : Qubit) : ()", new string[] { }, "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs", 8428L, 245L, 5L)]
[assembly: OperationDeclaration("_16Q_Grover", "Search () : Result[]", new string[] { }, "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs", 8638L, 257L, 5L)]
#line hidden
namespace _16Q_Grover
{
    public class Oracle : Operation<QArray<Qubit>, QVoid>
    {
        public Oracle(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.CCNOT), typeof(Microsoft.Quantum.Primitive.H) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get
            {
                return this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>, Microsoft.Quantum.Primitive.CCNOT>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.H>();
            }
        }

        public override Func<QArray<Qubit>, QVoid> Body
        {
            get => (q) =>
            {
#line hidden
                this.Factory.StartOperation("_16Q_Grover.Oracle", OperationFunctor.Body, q);
                var __result__ = default(QVoid);
                try
                {
#line 10 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveH.Apply(q[16L]);
#line 11 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[13L], q[14L], q[17L]));
#line 12 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 13 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 14 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 15 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 16 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 17 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[0L], q[2L], q[3L]));
#line 18 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 19 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 20 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 21 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 22 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 23 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[13L], q[14L], q[17L]));
#line 24 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 25 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 26 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 27 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 28 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 29 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[0L], q[2L], q[3L]));
#line 30 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 31 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 32 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 33 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 34 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 35 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[17L], q[18L], q[16L]));
#line 36 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[15L], q[18L]));
#line 37 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 38 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 39 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 40 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 41 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 42 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[1L], q[3L], q[4L]));
#line 43 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 44 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 45 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 46 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 47 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 48 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[15L], q[18L]));
#line 49 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[18L], q[17L], q[16L]));
#line 50 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[15L], q[18L]));
#line 51 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 52 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 53 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 54 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 55 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 56 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[1L], q[3L], q[4L]));
#line 57 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 58 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 59 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[8L], q[10L]));
#line 60 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 61 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 62 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[15L], q[18L]));
#line 63 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[13L], q[14L], q[17L]));
#line 64 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 65 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 66 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 67 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 68 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 69 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[0L], q[2L], q[3L]));
#line 70 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 71 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 72 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 73 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 74 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 75 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[13L], q[14L], q[17L]));
#line 76 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 77 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 78 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 79 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 80 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 81 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[0L], q[2L], q[3L]));
#line 82 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 83 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 84 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 85 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 86 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 87 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[17L], q[18L], q[16L]));
#line 88 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[15L], q[18L]));
#line 89 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 90 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 91 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 92 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 93 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 94 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[1L], q[3L], q[4L]));
#line 95 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 96 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 97 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 98 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 99 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 100 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[15L], q[18L]));
#line 101 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[18L], q[17L], q[16L]));
#line 102 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[15L], q[18L]));
#line 103 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 104 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 105 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 106 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 107 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 108 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[1L], q[3L], q[4L]));
#line 109 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 110 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 111 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[8L], q[10L]));
#line 112 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 113 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 114 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[15L], q[18L]));
#line 115 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveH.Apply(q[16L]);
#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("_16Q_Grover.Oracle", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> q)
        {
            return __m__.Run<Oracle, QArray<Qubit>, QVoid>(q);
        }
    }

    public class Diffusion : Operation<QArray<Qubit>, QVoid>
    {
        public Diffusion(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.CCNOT), typeof(Microsoft.Quantum.Primitive.H), typeof(Microsoft.Quantum.Primitive.X) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get
            {
                return this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>, Microsoft.Quantum.Primitive.CCNOT>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.H>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        public override Func<QArray<Qubit>, QVoid> Body
        {
            get => (q) =>
            {
#line hidden
                this.Factory.StartOperation("_16Q_Grover.Diffusion", OperationFunctor.Body, q);
                var __result__ = default(QVoid);
                try
                {
#line 123 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    foreach (var i in new Range(0L, 15L))
                    {
#line 125 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                        MicrosoftQuantumPrimitiveH.Apply(q[i]);
                    }

#line 127 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    foreach (var i in new Range(0L, 15L))
                    {
#line 129 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                        MicrosoftQuantumPrimitiveX.Apply(q[i]);
                    }

#line 132 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveH.Apply(q[15L]);
#line 133 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[13L], q[14L], q[17L]));
#line 134 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 135 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 136 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 137 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 138 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 139 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[0L], q[2L], q[3L]));
#line 140 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 141 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 142 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 143 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 144 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 145 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[13L], q[14L], q[17L]));
#line 146 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 147 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 148 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 149 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 150 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 151 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[0L], q[2L], q[3L]));
#line 152 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 153 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 154 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 155 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 156 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 157 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[17L], q[15L]));
#line 158 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 159 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 160 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 161 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 162 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 163 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[1L], q[3L], q[4L]));
#line 164 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 165 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 166 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 167 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 168 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 169 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[17L], q[15L]));
#line 170 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 171 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 172 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 173 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 174 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 175 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[1L], q[3L], q[4L]));
#line 176 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 177 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 178 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 179 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 180 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 181 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[13L], q[14L], q[17L]));
#line 182 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 183 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 184 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 185 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 186 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 187 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[0L], q[2L], q[3L]));
#line 188 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 189 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 190 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 191 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 192 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 193 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[13L], q[14L], q[17L]));
#line 194 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 195 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 196 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 197 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 198 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 199 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[0L], q[2L], q[3L]));
#line 200 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[3L], q[4L], q[5L]));
#line 201 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[5L], q[6L], q[7L]));
#line 202 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[7L], q[8L], q[9L]));
#line 203 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[9L], q[10L], q[11L]));
#line 204 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[11L], q[12L], q[13L]));
#line 205 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[17L], q[15L]));
#line 206 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 207 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 208 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 209 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 210 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 211 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[1L], q[3L], q[4L]));
#line 212 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 213 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 214 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 215 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 216 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 217 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[14L], q[17L], q[15L]));
#line 218 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 219 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 220 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 221 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 222 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 223 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[1L], q[3L], q[4L]));
#line 224 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[4L], q[5L], q[6L]));
#line 225 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[6L], q[7L], q[8L]));
#line 226 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[8L], q[9L], q[10L]));
#line 227 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[10L], q[11L], q[12L]));
#line 228 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((q[12L], q[13L], q[14L]));
#line 230 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    MicrosoftQuantumPrimitiveH.Apply(q[15L]);
#line 232 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    foreach (var i in new Range(0L, 15L))
                    {
#line 234 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                        MicrosoftQuantumPrimitiveX.Apply(q[i]);
                    }

#line 237 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    foreach (var i in new Range(0L, 15L))
                    {
#line 239 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                        MicrosoftQuantumPrimitiveH.Apply(q[i]);
                    }

#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("_16Q_Grover.Diffusion", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> q)
        {
            return __m__.Run<Diffusion, QArray<Qubit>, QVoid>(q);
        }
    }

    public class Set : Operation<(Result,Qubit), QVoid>
    {
        public Set(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.X) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected ICallable<Qubit, Result> M
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Result>, Microsoft.Quantum.Primitive.M>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        public override Func<(Result,Qubit), QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("_16Q_Grover.Set", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    var (desired,q1) = _args;
#line 248 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    var current = M.Apply<Result>(q1);
#line 249 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    if ((desired != current))
                    {
#line 251 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                        MicrosoftQuantumPrimitiveX.Apply(q1);
                    }

#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("_16Q_Grover.Set", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public class Search : Operation<QVoid, QArray<Result>>
    {
        public Search(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(_16Q_Grover.Diffusion), typeof(Microsoft.Quantum.Primitive.H), typeof(Microsoft.Quantum.Canon.MultiM), typeof(_16Q_Grover.Oracle), typeof(Microsoft.Quantum.Primitive.Release), typeof(_16Q_Grover.Set) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected Allocate Allocate
        {
            get
            {
                return this.Factory.Get<Allocate, Microsoft.Quantum.Primitive.Allocate>();
            }
        }

        protected ICallable<QArray<Qubit>, QVoid> Diffusion
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Qubit>, QVoid>, _16Q_Grover.Diffusion>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.H>();
            }
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MicrosoftQuantumCanonMultiM
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>, Microsoft.Quantum.Canon.MultiM>();
            }
        }

        protected ICallable<QArray<Qubit>, QVoid> Oracle
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Qubit>, QVoid>, _16Q_Grover.Oracle>();
            }
        }

        protected Release Release
        {
            get
            {
                return this.Factory.Get<Release, Microsoft.Quantum.Primitive.Release>();
            }
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get
            {
                return this.Factory.Get<ICallable<(Result,Qubit), QVoid>, _16Q_Grover.Set>();
            }
        }

        public override Func<QVoid, QArray<Result>> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("_16Q_Grover.Search", OperationFunctor.Body, _args);
                var __result__ = default(QArray<Result>);
                try
                {
#line 260 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    var resultSet = new QArray<Result>(16L);
#line 261 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    var q = Allocate.Apply(19L);
#line 263 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    var databaseRegister = q.Slice(new Range(0L, 15L));
#line 264 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    foreach (var i in new Range(0L, 16L))
                    {
#line 266 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                        MicrosoftQuantumPrimitiveH.Apply(q[i]);
                    }

#line 269 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    foreach (var i in new Range(0L, 200L))
                    {
#line 270 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                        Oracle.Apply(q);
#line 271 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                        Diffusion.Apply(q);
                    }

#line 273 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    resultSet = MicrosoftQuantumCanonMultiM.Apply<QArray<Result>>(databaseRegister);
#line 275 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    foreach (var i in new Range(0L, 18L))
                    {
#line 277 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                        Set.Apply((Result.Zero, q[i]));
                    }

#line hidden
                    Release.Apply(q);
#line hidden
                    __result__ = resultSet;
#line 281 "C:\\Users\\sneha\\16Q_grover\\16Q_Grover.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("_16Q_Grover.Search", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QArray<Result>> Run(IOperationFactory __m__)
        {
            return __m__.Run<Search, QVoid, QArray<Result>>(QVoid.Instance);
        }
    }
}