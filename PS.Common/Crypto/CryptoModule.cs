namespace PS.Common.Crypto
{
    using Autofac;

    public class CryptoModule
        : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<RijndaelCryptoProvider>()
                .Keyed<ICryptoProvider>("rijndael")
                .WithParameter("_defaultKey", "123456789012345678901234567890!@")
                ;

            builder
                .RegisterType<TripleDesCryptoProvider>()
                .Keyed<ICryptoProvider>("tdes")
                .WithParameter("_defaultKey", "123456789012345678901234567890!@")
                ;

            builder
                .RegisterType<DesCryptoProvider>()
                .Keyed<ICryptoProvider>("des")
                .WithParameter("_defaultKey", "123456789012345678901234567890!@")
                ;
        }
    }
}
