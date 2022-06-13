namespace Web3.fs.UnitTester

open Web3.fs

module UnitTester =

    type UnitTester =
        { chainId: ChainId
          contract: DeployedContract
          env: Web3Environment }
      
        member this.owner () = contractCall this.contract (ByName "owner") [] this.env
        
        member this.sendValue value = contractTransaction this.contract Receive [] value this.env
        
        member this.getBalance () = contractCall this.contract (ByName "getBalance") [] this.env
        
        member this.withdrawBalance () =
            contractTransaction this.contract (ByName "withdrawBalance") [] ZEROVALUE this.env

        member this.addr () = contractCall this.contract (ByName "addr") [] this.env

        member this.addrArraySz () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "addrArraySz") [Uint256 index] this.env)

        member this.addrArray () =  ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "addrArray") [Uint256 index] this.env)

        member this.aBool () = contractCall this.contract (ByName "aBool") [] this.env

        member this.aBoolArraySz () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "aBoolArraySz") [Uint256 index] this.env)

        member this.aBoolArray () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "aBoolArray") [Uint256 index] this.env)

        member this.someBytes () = contractCall this.contract (ByName "someBytes") [] this.env

        member this.someBytesArraySz () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "someBytesArraySz") [Uint256 index] this.env)

        member this.someBytesArray () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "someBytesArray") [Uint256 index] this.env)

        member this.sizedBytes () = contractCall this.contract (ByName "sizedBytes") [] this.env

        member this.sizedBytesArraySz () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "sizedBytesArraySz") [Uint256 index] this.env)

        member this.sizedBytesArray () = ["0";"1"] |> List.map(fun index ->contractCall this.contract (ByName "sizedBytesArray") [Uint256 index] this.env)

        member this.tinyInt () = contractCall this.contract (ByName "tinyInt") [] this.env

        member this.tinyIntArraySz () = ["0";"1"] |> List.map(fun index ->contractCall this.contract (ByName "tinyIntArraySz") [Uint256 index] this.env)

        member this.tinyIntArray () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "tinyIntArray") [Uint256 index] this.env)

        member this.bigInt () = contractCall this.contract (ByName "bigInt") [] this.env

        member this.bigIntArraySz () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "bigIntArraySz") [Uint256 index] this.env)

        member this.bigIntArray () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "bigIntArray") [Uint256 index] this.env)

        member this.tinyUint () = contractCall this.contract (ByName "tinyUint") [] this.env

        member this.tinyUintArraySz () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "tinyUintArraySz") [Uint256 index] this.env)

        member this.tinyUintArray () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "tinyUintArray") [Uint256 index] this.env)

        member this.someString () = contractCall this.contract (ByName "someString") [] this.env

        member this.someStringArraySz () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "someStringArraySz") [Uint256 index] this.env)

        member this.someStringArray () = ["0";"1"] |> List.map(fun index -> contractCall this.contract (ByName "someStringArray") [Uint256 index] this.env)

        member this.revertAllStorage () =
            contractTransaction this.contract (ByName "revertAllStorage") [] ZEROVALUE this.env

        member this.setAddr address =
            contractTransaction this.contract (ByName "setAddr") [Address address] ZEROVALUE this.env

        member this.setAddrArraySz addresses =
            contractTransaction this.contract (ByName "setAddrArraySz") [AddressArraySz addresses] ZEROVALUE this.env

        member this.setAddrArray addresses =
            contractTransaction this.contract (ByName "setAddrArray") [AddressArray addresses] ZEROVALUE this.env

        member this.setABool bool = 
            contractTransaction this.contract (ByName "setABool") [Bool bool] ZEROVALUE this.env

        member this.setABoolArraySz bools = 
            contractTransaction this.contract (ByName "setABoolArraySz") [BoolArraySz bools] ZEROVALUE this.env

        member this.setABoolArray bools = 
            contractTransaction this.contract (ByName "setABoolArray") [BoolArray bools] ZEROVALUE this.env

        member this.setSomeBytes bytes = 
            contractTransaction this.contract (ByName "setSomeBytes") [Bytes bytes ] ZEROVALUE this.env

        member this.setSomeBytesArraySz bytesArr = 
            contractTransaction this.contract (ByName "setSomeBytesArraySz") [BytesArraySz bytesArr ] ZEROVALUE this.env

        member this.setSomeBytesArray bytesArr = 
            contractTransaction this.contract (ByName "setSomeBytesArray") [BytesArray bytesArr ] ZEROVALUE this.env

        member this.setSizedBytes byte16 = 
            contractTransaction this.contract (ByName "setSizedBytes") [Byte16 byte16 ] ZEROVALUE this.env

        member this.setSizedBytesArraySz byte16Arr = 
            contractTransaction this.contract (ByName "setSizedBytesArraySz") [Byte16ArraySz byte16Arr ] ZEROVALUE this.env

        member this.setSizedBytesArray byte16Arr = 
            contractTransaction this.contract (ByName "setSizedBytesArray") [Byte16Array byte16Arr ] ZEROVALUE this.env

        member this.setTinyInt int = 
            contractTransaction this.contract (ByName "setTinyInt") [Int8 int] ZEROVALUE this.env

        member this.setTinyIntArraySz intArr = 
            contractTransaction this.contract (ByName "setTinyIntArraySz") [Int8ArraySz intArr] ZEROVALUE this.env

        member this.setTinyIntArray intArr = 
            contractTransaction this.contract (ByName "setTinyIntArray") [Int8Array intArr] ZEROVALUE this.env

        member this.setBigInt int = 
            contractTransaction this.contract (ByName "setBigInt") [Int256 int] ZEROVALUE this.env

        member this.setBigIntArraySz intArr = 
            contractTransaction this.contract (ByName "setBigIntArraySz") [Int256ArraySz intArr] ZEROVALUE this.env

        member this.setBigIntArray intArr = 
            contractTransaction this.contract (ByName "setBigIntArray") [Int256Array intArr] ZEROVALUE this.env

        member this.setTinyUint uint = 
            contractTransaction this.contract (ByName "setTinyUint") [Uint8 uint] ZEROVALUE this.env

        member this.setTinyUintArraySz uintArr = 
            contractTransaction this.contract (ByName "setTinyUintArraySz") [Uint8ArraySz uintArr] ZEROVALUE this.env

        member this.setTinyUintArray uintArr = 
            contractTransaction this.contract (ByName "setTinyUintArray") [Uint8Array uintArr] ZEROVALUE this.env

        member this.setSomeString str = 
            contractTransaction this.contract (ByName "setSomeString") [String str] ZEROVALUE this.env

        member this.setSomeStringArraySz strArr = 
            contractTransaction this.contract (ByName "setSomeStringArraySz") [StringArraySz strArr] ZEROVALUE this.env

        member this.setSomeStringArray strArr = 
            contractTransaction this.contract (ByName "setSomeStringArray") [StringArray strArr] ZEROVALUE this.env

    
    ///
    /// Returns an instance of the UnitTester record, ready for interaction.
    /// The path value should be pointing to a `solc` json file. 
    let loadUnitTester path chainId address env =
        let abi, _ = returnABIAndBytecodeFromSolcJsonFile path
        loadDeployedContract abi chainId address 
        |> optimisticallyBindDeployedContract
        |> fun _contract ->
            { chainId = chainId
              contract = _contract
              env = env }


    ///
    /// Returns an instance of the UnitTester record, deployed and ready for
    /// interaction. The path value should be pointing to a `solc` json file.
    let deployAndLoadUnitTester path chainId env = 
        let abi, bytecode = returnABIAndBytecodeFromSolcJsonFile path
        prepareDeployAndLoadContract bytecode abi chainId [Address env.constants.walletAddress] ZEROVALUE env
        |> optimisticallyBindDeployedContract
        |> fun _contract ->
            { chainId = chainId
              contract = _contract
              env = env }
