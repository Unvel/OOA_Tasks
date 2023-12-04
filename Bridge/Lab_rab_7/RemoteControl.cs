using System;

namespace Bridge
{
    public class RemoteControl : IRemoteControl
    {
        protected IRemoteControl Remote { get; private set; }
        public int Power { get; protected set; }
        public int Mode { get; protected set; }

        public RemoteControl(IRemoteControl remote)
        {
            if (remote == null)
                throw new ArgumentNullException(nameof(remote), "Ошибка null ");
            Remote = remote;
        }

        public void TurnOn()
        {
            Remote.TurnOn();
        }

        public void TurnOff()
        {
            Remote.TurnOff();
        }

        public void PowerPlus()
        {
            Remote.SetPower(++Power);
        }

        public void PowerMinus()
        {
            Remote.SetPower(--Power);
        }

        public void ModeNext()
        {
            Remote.SetMode(++Mode);
        }

        public void ModePrevious()
        {
            Remote.SetMode(--Mode);
        }

        public void SetMode(int mode)
        {
            Remote.SetMode(mode);
        }

        public void SetPower(int power)
        {
            Remote.SetPower(power);
        }
    }
}
