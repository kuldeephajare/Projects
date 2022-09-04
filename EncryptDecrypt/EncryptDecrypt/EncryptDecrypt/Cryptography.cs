// -----------------------------------------------------------------------------
//
// Copyright © 2021 Everything Embedded 
// All rights reserved
//
// Unauthorised copying of this file, via any medium is strictly prohibited.
// Proprietary and confidential. No liablity assumed.
//
//-----------------------------------------------------------------------------

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.OpenSsl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Asn1.X509;

namespace EncryptDecrypt
{
    class Cryptography
    {
        public static string EncryptWithPublicKey(string PEMFileName, string Text)
        {
            byte[] BytesToOperateOn = Encoding.UTF8.GetBytes(Text);
            TextReader reader = File.OpenText(PEMFileName);
            AsymmetricKeyParameter KeyPair = (AsymmetricKeyParameter)new PemReader(reader).ReadObject();

            OaepEncoding Engine = new OaepEncoding(new RsaEngine(), new Sha256Digest(), new Sha256Digest(), null);
            Engine.Init(true, KeyPair);  //if encryption is true use public key else use private
            byte[] Output = Engine.ProcessBlock(BytesToOperateOn, 0, BytesToOperateOn.Length);
            string Result = Convert.ToBase64String(Output);
            return Result;
        }

        public static string DecryptWithPrivateKey(string PEMFileName, string Text)
        {
            byte[] BytesToOperateOn = Convert.FromBase64String(Text); 
            TextReader reader = File.OpenText(PEMFileName);
            AsymmetricCipherKeyPair KeyPair = (AsymmetricCipherKeyPair)new PemReader(reader).ReadObject();

            OaepEncoding Engine = new OaepEncoding(new RsaEngine(), new Sha256Digest(), new Sha256Digest(), null);
            Engine.Init(false, KeyPair.Private);  //if encryption is true use public key else use private
            string Result = Encoding.UTF8.GetString(Engine.ProcessBlock(BytesToOperateOn, 0, BytesToOperateOn.Length));
            return Result;
        }
    }
}
