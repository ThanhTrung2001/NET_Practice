using DesignPattern.Structural.Decorator.Interface;

namespace DesignPattern.Structural.Decorator.Abstract
{
    public abstract class Decorator : IAccountSecurity
    {
        protected IAccountSecurity security;
        public Decorator(IAccountSecurity security)
        {
            this.security = security;
        }

        public void SetAccountSecurity(IAccountSecurity security)
        {
            this.security = security;
        }

        public virtual void Login()
        {
            this.security.Login();
        }
    }
}
