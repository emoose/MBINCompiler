namespace libMBIN {

    public static class Version {

        public static System.Version AssemblyVersion => System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        public static System.Version NMSVersion => new System.Version( AssemblyVersion.Major, AssemblyVersion.Minor );

    }

}
