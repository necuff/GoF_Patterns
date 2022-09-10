using CommandPattern.Components;

Light lamp = new Light();

Command switchOn = new SwitchOnCommand(lamp);
Command switchOff = new SwitchOffCommand(lamp);

Switch mySwitch = new Switch();

mySwitch.Register("on", switchOn);
mySwitch.Register("off", switchOff);

mySwitch.Execute("on");
mySwitch.Execute("off");
//mySwitch.Execute("ffd");
