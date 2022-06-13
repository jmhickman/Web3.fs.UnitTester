// Requires references to Web3.fs and Web3.fs.UnitTester. Build local Nuget,
// manually reference assemblies, etc. Will need many other files if ref is 
// assembly

open Web3.fs
open Web3.fs.UnitTester.UnitTester

let walletAddress = ""
let env = createWeb3Environment "http://127.0.0.1:1248" "2.0" walletAddress
let logIt = env.log Log
let logAndIgnore = fun x -> env.log Log x |> ignore

(Library "----Deploying contract...") |> Ok |> logIt 
let unitTester = deployAndLoadUnitTester "./UnitTestingContract.json" GANACHE env
//// Addresses
let testAddresstypes () =    
    (Library "----Beginning Address type tests...") |> Ok |> logAndIgnore
    unitTester.setAddr "0x05d796d358651c4d63db2b2fdd11719a347c58ae" |> logAndIgnore
    unitTester.setAddrArraySz ["0x33651c5492a5353e78d6ada9eb025c9dde18f4d2"; "0x58d7c99dbc83125b8b8fe705318d57caeb9aacba"] |> logAndIgnore
    unitTester.setAddrArray ["0x6e879bb1ec2f6c1f4c7cdf111546744480f0cedb"; "0x33651c5492a5353e78d6ada9eb025c9dde18f4d2"] |> logAndIgnore
    unitTester.addr () |> logAndIgnore 
    unitTester.addrArraySz () |> List.map logIt |> ignore
    unitTester.addrArray () |> List.map logIt |> ignore


//// booleans
let testBooleans () =    
    (Library "----Beginning Boolean type tests...") |> Ok |> logAndIgnore
    unitTester.setABool true |> logAndIgnore 
    unitTester.setABoolArraySz [true; false] |> logAndIgnore 
    unitTester.setABoolArray [true; false] |> logAndIgnore 
    unitTester.aBool () |> logAndIgnore 
    unitTester.aBoolArraySz () |> List.map logIt |> ignore
    unitTester.aBoolArray () |> List.map logIt |> ignore

//// Bytes
let testBytes () =    
    (Library "----Beginning Bytes type tests...") |> Ok |> logAndIgnore 
    unitTester.setSomeBytes "0x414141414141414141414141" |> logAndIgnore 
    unitTester.setSomeBytesArraySz [Bytes "0x414141414141414141414141"; Bytes "0x414141414141414141414141"] |> logAndIgnore 
    unitTester.setSomeBytesArray [Bytes "0x414141414141414141414141"; Bytes "0x414141414141414141414141"] |> logAndIgnore 
    unitTester.someBytes () |> logAndIgnore 
    unitTester.someBytesArraySz () |> List.map logIt |> ignore
    unitTester.someBytesArray () |> List.map logIt |> ignore

//// Sized Bytes
let testSizedBytes () =    
    (Library "----Beginning Sized Byte type tests...") |> Ok |> logAndIgnore
    unitTester.setSizedBytes "0x42424242424242424242424242424242" |> logAndIgnore 
    unitTester.setSizedBytesArraySz ["0x42424242424242424242424242424242"; "0x65656565656565656565656565656565"] |> logAndIgnore 
    unitTester.setSizedBytesArray ["0x80808080808080808080808080808080"; "0x20202020202020202020202020202020"] |> logAndIgnore 
    unitTester.sizedBytes () |> logAndIgnore 
    unitTester.sizedBytesArraySz () |> List.map logIt |> ignore
    unitTester.sizedBytesArray () |> List.map logIt |> ignore

//// Int8
let testInt8 () =
    (Library "----Beginning Int 8 type tests...") |> Ok |> logAndIgnore 
    unitTester.setTinyInt "16" |> logAndIgnore
    unitTester.setTinyIntArraySz ["8";"16"] |> logAndIgnore 
    unitTester.setTinyIntArray ["24";"32"] |> logAndIgnore 
    unitTester.tinyInt () |> logAndIgnore 
    unitTester.tinyIntArraySz () |> List.map logIt |> ignore
    unitTester.tinyIntArray () |> List.map logIt |> ignore

//// Int256
let testInt256 () =
    (Library "----Beginning Int 256 type tests...") |> Ok |> logAndIgnore 
    unitTester.setBigInt "16" |> logAndIgnore
    unitTester.setBigIntArraySz ["8";"16"] |> logAndIgnore 
    unitTester.setBigIntArray ["24";"32"] |> logAndIgnore
    unitTester.bigInt () |> logAndIgnore 
    unitTester.bigIntArraySz () |> List.map logIt |> ignore
    unitTester.bigIntArray () |> List.map logIt |> ignore

//// Uint8
let testUint8 () =
    (Library "----Beginning Uint 8 type tests...") |> Ok |> logAndIgnore
    unitTester.setTinyUint "16" |> logAndIgnore 
    unitTester.setTinyUintArraySz ["8";"16"] |> logAndIgnore
    unitTester.setTinyUintArray ["24";"32"] |> logAndIgnore
    unitTester.tinyUint () |> logAndIgnore 
    unitTester.tinyUintArraySz () |> List.map logIt |> ignore
    unitTester.tinyUintArray () |> List.map logIt |> ignore

//// Strings
let testStrings () =
    (Library "----Beginning String type tests...") |> Ok |> logAndIgnore 
    unitTester.setSomeString "0x414141414141414141414141" |> logAndIgnore 
    unitTester.setSomeStringArraySz [String "HurfDerpDurrr"; String "HurfDerpDurrr"] |> logAndIgnore
    unitTester.setSomeStringArray [String "HurfDerpDurrr"; String "HurfDerpDurrr"] |> logAndIgnore 
    unitTester.someString () |> logAndIgnore 
    unitTester.someStringArraySz () |> List.map logIt |> ignore
    unitTester.someStringArray () |> List.map logIt |> ignore
    
    
let testSendAndReceive () =
    (Library "----Beginning send and receive tests") |> Ok |> logAndIgnore
    unitTester.getBalance () |> logAndIgnore
    unitTester.sendValue ((Ether "1") |> asWei) |> logAndIgnore
    unitTester.getBalance () |> logAndIgnore
    unitTester.withdrawBalance () |> logAndIgnore
    unitTester.getBalance () |> logAndIgnore
    
//testAddresstypes ()
//testBooleans ()
//testBytes ()
//testInt8 ()
//testInt256 ()
//testStrings ()
//testUint8 ()
//testSizedBytes ()
//testSendAndReceive ()