﻿namespace CRepublic.Boom.Library.Sodium
{
    using CRepublic.Boom.Library.TweetNaCl;

    internal class KeyPair
    {
        public KeyPair()
        {
            curve25519xsalsa20poly1305.crypto_box_keypair(this.PublicKey, this.SecretKey);
        }

        public byte[] PublicKey
        {
            get;
        } = new byte[32];

        public byte[] SecretKey
        {
            get;
        } = new byte[32];
    }
}