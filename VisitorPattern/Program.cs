using System;

// Interface for the visitor
public interface IWeaponVisitor
{
    void VisitSword(Sword sword);
    void VisitAxe(Axe axe);
    void VisitSpear(Spear spear);
}

// Abstract class for the medieval weapon
public abstract class Weapon
{
    public abstract void Accept(IWeaponVisitor visitor);
}

// Concrete implementation of a Sword
public class Sword : Weapon
{
    public override void Accept(IWeaponVisitor visitor)
    {
        visitor.VisitSword(this);
    }
}

// Concrete implementation of an Axe
public class Axe : Weapon
{
    public override void Accept(IWeaponVisitor visitor)
    {
        visitor.VisitAxe(this);
    }
}

// Concrete implementation of a Spear
public class Spear : Weapon
{
    public override void Accept(IWeaponVisitor visitor)
    {
        visitor.VisitSpear(this);
    }
}

// Concrete implementation of a visitor - Blacksmith
public class Blacksmith : IWeaponVisitor
{
    public void VisitSword(Sword sword)
    {
        Console.WriteLine("Sharpening the sword.");
    }

    public void VisitAxe(Axe axe)
    {
        Console.WriteLine("Adding a new handle to the axe.");
    }

    public void VisitSpear(Spear spear)
    {
        Console.WriteLine("Polishing the spearhead.");
    }
}

// Client code to demonstrate the Visitor pattern
public class Program
{
    public static void Main(string[] args)
    {
        // Create some medieval weapons
        var sword = new Sword();
        var axe = new Axe();
        var spear = new Spear();

        // Create a blacksmith (visitor)
        var blacksmith = new Blacksmith();

        // Apply the visitor (blacksmith) to each weapon
        sword.Accept(blacksmith);
        axe.Accept(blacksmith);
        spear.Accept(blacksmith);
    }
}
