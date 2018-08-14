namespace _16Q_Grover
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Oracle (q:Qubit[]) : ()
    {
        body
        {
            H(q[16]);
            CCNOT(q[13],q[14],q[17]);
            CCNOT(q[11],q[12],q[13]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[0],q[2],q[3]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT( q[13],q[14],q[17]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[0],q[2],q[3]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT( q[17],q[18],q[16]);
            CCNOT( q[14],q[15],q[18]);
            CCNOT( q[12],q[13],q[14]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[8],q[9],q[10]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[1],q[3],q[4]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[8],q[9],q[10]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[12],q[13],q[14]);
            CCNOT( q[14],q[15],q[18]);
            CCNOT( q[18],q[17],q[16]);
            CCNOT( q[14],q[15],q[18]);
            CCNOT( q[12],q[13],q[14]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[8],q[9],q[10]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[1],q[3],q[4]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[9],q[8],q[10]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[12],q[13],q[14]);
            CCNOT( q[14],q[15],q[18]);
            CCNOT(q[13],q[14],q[17]);
            CCNOT(q[11],q[12],q[13]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[0],q[2],q[3]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT( q[13],q[14],q[17]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[0],q[2],q[3]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT( q[17],q[18],q[16]);
            CCNOT( q[14],q[15],q[18]);
            CCNOT( q[12],q[13],q[14]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[8],q[9],q[10]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[1],q[3],q[4]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[8],q[9],q[10]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[12],q[13],q[14]);
            CCNOT( q[14],q[15],q[18]);
            CCNOT( q[18],q[17],q[16]);
            CCNOT( q[14],q[15],q[18]);
            CCNOT( q[12],q[13],q[14]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[8],q[9],q[10]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[1],q[3],q[4]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[9],q[8],q[10]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[12],q[13],q[14]);
            CCNOT( q[14],q[15],q[18]);
            H(q[16]);
        }
    }

    operation Diffusion (q:Qubit[]) : ()
    {
        body
        {
            for(i in 0..15)
            {
                H(q[i]);
            }
            for(i in 0..15)
            {
                X(q[i]);
            }

            H(q[15]);
            CCNOT(q[13],q[14],q[17]);
            CCNOT(q[11],q[12],q[13]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[0],q[2],q[3]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT( q[13],q[14],q[17]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[0],q[2],q[3]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT(q[14],q[17],q[15]);
            CCNOT(q[12],q[13],q[14]);
            CCNOT(q[10],q[11],q[12]);
            CCNOT(q[8],q[9],q[10]);
            CCNOT(q[6],q[7],q[8]);
            CCNOT(q[4],q[5],q[6]);
            CCNOT(q[1],q[3],q[4]);
            CCNOT(q[4],q[5],q[6]);
            CCNOT(q[6],q[7],q[8]);
            CCNOT(q[8],q[9],q[10]);
            CCNOT(q[10],q[11],q[12]);
            CCNOT(q[12],q[13],q[14]);
            CCNOT(q[14],q[17],q[15]);
            CCNOT(q[12],q[13],q[14]);
            CCNOT(q[10],q[11],q[12]);
            CCNOT(q[8],q[9],q[10]);
            CCNOT(q[6],q[7],q[8]);
            CCNOT(q[4],q[5],q[6]);
            CCNOT(q[1],q[3],q[4]);
            CCNOT(q[4],q[5],q[6]);
            CCNOT(q[6],q[7],q[8]);
            CCNOT(q[8],q[9],q[10]);
            CCNOT(q[10],q[11],q[12]);
            CCNOT(q[12],q[13],q[14]);
            CCNOT(q[13],q[14],q[17]);
            CCNOT(q[11],q[12],q[13]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[0],q[2],q[3]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT( q[13],q[14],q[17]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[0],q[2],q[3]);
            CCNOT( q[3],q[4],q[5]);
            CCNOT( q[5],q[6],q[7]);
            CCNOT( q[7],q[8],q[9]);
            CCNOT( q[9],q[10],q[11]);
            CCNOT( q[11],q[12],q[13]);
            CCNOT( q[14],q[17],q[15]);
            CCNOT( q[12],q[13],q[14]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[8],q[9],q[10]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[1],q[3],q[4]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[8],q[9],q[10]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[12],q[13],q[14]);
            CCNOT( q[14],q[17],q[15]);
            CCNOT( q[12],q[13],q[14]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[8],q[9],q[10]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[1],q[3],q[4]);
            CCNOT( q[4],q[5],q[6]);
            CCNOT( q[6],q[7],q[8]);
            CCNOT( q[8],q[9],q[10]);
            CCNOT( q[10],q[11],q[12]);
            CCNOT( q[12],q[13],q[14]);

            H(q[15]);
            
            for(i in 0..15)
            {
                X(q[i]);
            }

            for(i in 0..15)
            {
                H(q[i]);
            }
        }
    }

    operation Set (desired: Result, q1 :Qubit) : ()
    {
        body
        {
            let current=M(q1);
            if(desired!=current)
            {
                X(q1);
            }
        }
    }

    operation Search () : (Result[])
    {
        body
        {
            mutable resultSet=new Result[16];
            using(q=Qubit[19])
            {
                let databaseRegister=q[0..15];
                for (i in 0..16)
                {
                    H(q[i]);
                }

                for(i in 0..200){
                    Oracle(q);
                    Diffusion(q);
                }
                set resultSet=MultiM(databaseRegister);

                for (i in 0..18)
                {
                    Set(Zero,q[i]);
                }
            }

            return (resultSet);
        }
    }

}
