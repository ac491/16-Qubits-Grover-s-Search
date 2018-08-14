namespace Microsoft.Research.Liquid

module UserSample =
    open System
    open Util
    open Operations
    //open Native             // Support for Native Interop
    //open HamiltonianGates   // Extra gates for doing Hamiltonian simulations
    //open Tests              // All the built-in tests

    /// <summary>
    /// Performs an arbitrary rotation around X. 
    /// </summary>
    /// <param name="theta">Angle to rotate by</param>
    /// <param name="qs">The head qubit of this list is operated on.</param>
    let rotX (theta:float) (qs:Qubits) =
        let gate (theta:float) =
            let nam     = "Rx" + theta.ToString("F2")
            new Gate(
                Name    = nam,
                Help    = sprintf "Rotate in X by: %f" theta,
                Mat     = (
                    let phi     = theta / 2.0
                    let c       = Math.Cos phi
                    let s       = Math.Sin phi
                    CSMat(2,[0,0,c,0.;0,1,0.,-s;1,0,0.,-s;1,1,c,0.])),
                Draw    = "\\gate{" + nam + "}"
                )
        (gate theta).Run qs
    
    let oracle (qs:Qubits) =
        let h i     = H [qs.[i]]
        let m i     = M [qs.[i]]
        let x i     = X [qs.[i]]
        let ccx i j k = CCNOT[qs.[i];qs.[j];qs.[k]]
        let cx i j    =CNOT[qs.[i];qs.[j]]
        
        ccx 13 14 17
        ccx 11 12 13
        ccx 9 10 11
        ccx 7 8 9
        ccx 5 6 7
        ccx 3 4 5
        ccx 0 2 3
        ccx 3 4 5
        ccx 5 6 7
        ccx 7 8 9
        ccx 9 10 11
        ccx 11 12 13
        ccx 13 14 17
        ccx 11 12 13
        ccx 9 10 11
        ccx 7 8 9
        ccx 5 6 7
        ccx 3 4 5
        ccx 0 2 3
        ccx 3 4 5
        ccx 5 6 7
        ccx 7 8 9
        ccx 9 10 11
        ccx 11 12 13
        ccx 17 18 16
        ccx 14 15 18
        ccx 12 13 14
        ccx 10 11 12
        ccx 8 9 10
        ccx 6 7 8 
        ccx 4 5 6
        ccx 1 3 4
        ccx 4 5 6
        ccx 6 7 8
        ccx 8 9 10
        ccx 10 11 12
        ccx 12 13 14
        ccx 14 15 18
        ccx 18 17 16
        ccx 14 15 18
        ccx 12 13 14
        ccx 10 11 12
        ccx 8 9 10
        ccx 6 7 8 
        ccx 4 5 6
        ccx 1 3 4
        ccx 4 5 6
        ccx 6 7 8
        ccx 8 9 10
        ccx 10 11 12
        ccx 12 13 14
        ccx 14 15 18
        ccx 13 14 17
        ccx 11 12 13
        ccx 9 10 11
        ccx 7 8 9
        ccx 5 6 7
        ccx 3 4 5
        ccx 0 2 3
        ccx 3 4 5
        ccx 5 6 7
        ccx 7 8 9
        ccx 9 10 11
        ccx 11 12 13
        ccx 13 14 17
        ccx 11 12 13
        ccx 9 10 11
        ccx 7 8 9
        ccx 5 6 7
        ccx 3 4 5
        ccx 0 2 3
        ccx 3 4 5
        ccx 5 6 7
        ccx 7 8 9
        ccx 9 10 11
        ccx 11 12 13
        ccx 17 18 16
        ccx 14 15 18
        ccx 12 13 14
        ccx 10 11 12
        ccx 8 9 10
        ccx 6 7 8 
        ccx 4 5 6
        ccx 1 3 4
        ccx 4 5 6
        ccx 6 7 8
        ccx 8 9 10
        ccx 10 11 12
        ccx 12 13 14
        ccx 14 15 18
        ccx 18 17 16
        ccx 14 15 18
        ccx 12 13 14
        ccx 10 11 12
        ccx 8 9 10
        ccx 6 7 8 
        ccx 4 5 6
        ccx 1 3 4
        ccx 4 5 6
        ccx 6 7 8
        ccx 8 9 10
        ccx 10 11 12
        ccx 12 13 14
        ccx 14 15 18
        
    
    let diffusion (qs:Qubits) =
        let h i     = H [qs.[i]]
        let m i     = M [qs.[i]]
        let x i     = X [qs.[i]]
        let ccx i j k = CCNOT[qs.[i];qs.[j];qs.[k]]
        let cx i j    = CNOT[qs.[i];qs.[j]]
        for i in 0..15 do
            h i
        for i in 0..15 do
            x i
        h 15

        ccx 13 14 17
        ccx 11 12 13
        ccx 9 10 11
        ccx 7 8 9
        ccx 5 6 7
        ccx 3 4 5
        ccx 0 2 3
        ccx 3 4 5
        ccx 5 6 7
        ccx 7 8 9
        ccx 9 10 11
        ccx 11 12 13
        ccx 13 14 17
        ccx 11 12 13
        ccx 9 10 11
        ccx 7 8 9
        ccx 5 6 7
        ccx 3 4 5
        ccx 0 2 3
        ccx 3 4 5
        ccx 5 6 7
        ccx 7 8 9
        ccx 9 10 11
        ccx 11 12 13
        ccx 14 17 15
        ccx 12 13 14
        ccx 10 11 12
        ccx 8 9 10
        ccx 6 7 8
        ccx 4 5 6
        ccx 1 3 4
        ccx  4 5 6
        ccx 6 7 8
        ccx 8 9 10
        ccx 10 11 12
        ccx 12 13 14
        ccx 14 17 15
        ccx 12 13 14
        ccx 10 11 12
        ccx 8 9 10
        ccx 6 7 8
        ccx 4 5 6
        ccx 1 3 4
        ccx  4 5 6
        ccx 6 7 8
        ccx 8 9 10
        ccx 10 11 12
        ccx 12 13 14
        ccx 13 14 17
        ccx 11 12 13
        ccx 9 10 11
        ccx 7 8 9
        ccx 5 6 7
        ccx 3 4 5
        ccx 0 2 3
        ccx 3 4 5
        ccx 5 6 7
        ccx 7 8 9
        ccx 9 10 11
        ccx 11 12 13
        ccx 13 14 17
        ccx 11 12 13
        ccx 9 10 11
        ccx 7 8 9
        ccx 5 6 7
        ccx 3 4 5
        ccx 0 2 3
        ccx 3 4 5
        ccx 5 6 7
        ccx 7 8 9
        ccx 9 10 11
        ccx 11 12 13
        ccx 14 17 15
        ccx 12 13 14
        ccx 10 11 12
        ccx 8 9 10
        ccx 6 7 8
        ccx 4 5 6
        ccx 1 3 4
        ccx  4 5 6
        ccx 6 7 8
        ccx 8 9 10
        ccx 10 11 12
        ccx 12 13 14
        ccx 14 17 15
        ccx 12 13 14
        ccx 10 11 12
        ccx 8 9 10
        ccx 6 7 8
        ccx 4 5 6
        ccx 1 3 4
        ccx  4 5 6
        ccx 6 7 8
        ccx 8 9 10
        ccx 10 11 12
        ccx 12 13 14


        h 15
        for i in 0..15 do
            x i
        for i in 0..15 do
            h i
        


    [<LQD>]
    let __UserSample() =
         let stats      = Array.create 16 0
         let k          = Ket(19)
         let circ1      = Circuit.Compile oracle k.Qubits
         let optCirc1   = circ1.GrowGates(k)
         show "Test1:"
         optCirc1.Dump()
         optCirc1.RenderHT("Test1")
         let circ2      = Circuit.Compile diffusion k.Qubits
         let optCirc2   = circ2.GrowGates(k)

         show "Test2:"
         optCirc2.Dump()
         optCirc2.RenderHT("Test2")
         let qs = k.Reset(19)
         let h i     = H [qs.[i]]
         let m i     = M [qs.[i]]
         let x i     = X [qs.[i]]
         for i in 0..15 do
                h  i
         x 16
         h 16
         for i in 0..200 do
            optCirc1.Run qs
            optCirc2.Run qs
         for i in 0..15 do
            m i
         for i in 0..15 do
            stats.[i] <- qs.[i].Bit.v
         for i in 0..15 do
            show "val[%d]=%d" i stats.[i]
            

            
module Main =
    open App

    /// <summary>
    /// The main entry point for Liquid.
    /// </summary>
    [<EntryPoint>]
    let Main _ =
        RunLiquid ()
