namespace libMBIN {
    public static class Version {

        public static string GetVersionString() {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

    }
}
