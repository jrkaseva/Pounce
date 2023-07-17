using Jypeli;

public class FysiikkaPeli2 : PhysicsGame
{
    int gameLevel = 1;

    int[] sounds = new int[] { };

    PlatformCharacter player;

    const double SpeedMove = 300;
    const double JumpSpeed = 800;

    /// <summary>
    /// Peli alkaa
    /// </summary>
    public override void Begin()
    {
        MainMenu();
    }


    /// <summary>
    /// NextLevel aliohjelma asettaa gameLevel:n arvon mukaan tason
    /// </summary>
    void NextLevel()
    {
        ClearAll();

        if (gameLevel == 1) Level1();
        else if (gameLevel == 2) Level2();
        else if (gameLevel == 3) Level3();
        else if (gameLevel == 4) Level4();
        else if (gameLevel == 5) Level5();
        else if (gameLevel > 5) VictoryScreen();
    }


    void Level1()
    {
        Level.Background.Color = Color.Charcoal;
        Level.CreateBottomBorder(1.0, true);
        Level.CreateLeftBorder(1.0, true);
        Level.CreateRightBorder(1.0, true);
        Level.CreateTopBorder(1.0, false);
        PhysicsObject muuri1 = LuoMuuri(Level.Left + 300.0, Level.Bottom + 50.0);
        Add(muuri1);
        PhysicsObject muuri2 = LuoMuuri(muuri1.X + 400.0, muuri1.Y);
        Add(muuri2);
        PhysicsObject vaara1 = LuoVaarat(muuri1.X - 100.0, muuri1.Y - 25.0);
        Add(vaara1);
        PhysicsObject vaara2 = LuoVaarat(muuri1.X + 100.0, muuri1.Y - 25.0);
        Add(vaara2);
        PhysicsObject vaara3 = LuoVaarat(muuri2.X - 100.0, muuri1.Y - 25.0);
        Add(vaara3);
        PhysicsObject vaara4 = LuoVaarat(muuri2.X + 50.0, muuri1.Y - 25.0);
        Add(vaara4);
        PhysicsObject vaara5 = LuoVaarat(muuri1.X + 50.0, muuri1.Y - 25.0);
        Add(vaara5);
        PhysicsObject vaara6 = LuoVaarat(muuri2.X - 50.0, muuri1.Y - 25.0);
        Add(vaara6);
        PhysicsObject goal = LuoMaali(muuri2.X + 150.0, vaara1.Y);
        Add(goal);

        Gravity = new Vector(0, -1500);
        Controls();
        PlayerSettings();
        CameraSettings();
    }


    void Level2()
    {
        Level.Background.Color = Color.Charcoal;
        Level.CreateBottomBorder(1.0, true);
        Level.CreateLeftBorder(1.0, true);
        Level.CreateRightBorder(1.0, true);
        Level.CreateTopBorder(1.0, false);
        PhysicsObject muuri1 = LuoMuuri(Level.Left + 300.0, Level.Bottom + 50.0);
        Add(muuri1);
        PhysicsObject muuri2 = LuoMuuri(muuri1.X + 400.0, muuri1.Y);
        Add(muuri2);
        GameObject vaara1 = LuoVaarat(muuri1.X - 50.0, muuri1.Y - 25.0);
        Add(vaara1);
        GameObject vaara2 = LuoVaarat(muuri1.X + 100.0, muuri1.Y - 25.0);
        Add(vaara2);
        GameObject vaara3 = LuoVaarat(muuri1.X + 200.0, muuri1.Y - 25.0);
        Add(vaara3);
        GameObject vaara4 = LuoVaarat(muuri2.X - 150.0, muuri1.Y - 25.0);
        Add(vaara4);
        GameObject vaara5 = LuoVaarat(muuri1.X + 150.0, muuri1.Y - 25.0);
        Add(vaara5);
        GameObject vaara6 = LuoVaarat(muuri1.X + 50.0, muuri1.Y - 25.0);
        Add(vaara6);
        GameObject goal = LuoMaali(muuri2.X + 150.0, vaara1.Y);
        Add(goal);

        Gravity = new Vector(0, -1500);
        Controls();
        PlayerSettings();
        CameraSettings();
    }


    void Level3()
    {
        Level.Background.Color = Color.Charcoal;
        Level.CreateBottomBorder(1.0, true);
        Level.CreateLeftBorder(1.0, true);
        Level.CreateRightBorder(1.0, true);
        Level.CreateTopBorder(1.0, false);
        PhysicsObject muuri1 = LuoMuuri(Level.Left + 300.0, Level.Bottom + 50.0);
        Add(muuri1);
        PhysicsObject muuri2 = LuoMuuri(muuri1.X + 400.0, muuri1.Y);
        Add(muuri2);
        GameObject vaara1 = LuoVaarat(muuri1.X - 100.0, muuri1.Y - 25.0);
        Add(vaara1);
        GameObject vaara2 = LuoVaarat(muuri1.X + 100.0, muuri1.Y - 25.0);
        Add(vaara2);
        GameObject vaara3 = LuoVaarat(muuri2.X - 100.0, muuri1.Y - 25.0);
        Add(vaara3);
        GameObject vaara4 = LuoVaarat(muuri2.X + 50.0, muuri1.Y - 25.0);
        Add(vaara4);
        GameObject vaara5 = LuoVaarat(muuri1.X + 50.0, muuri1.Y - 25.0);
        Add(vaara5);
        GameObject vaara6 = LuoVaarat(muuri2.X - 50.0, muuri1.Y - 25.0);
        Add(vaara6);
        GameObject goal = LuoMaali(muuri2.X + 150.0, vaara1.Y);
        Add(goal);

        Gravity = new Vector(0, -1500);
        Controls();
        PlayerSettings();
        CameraSettings();
    }


    void Level4()
    {
        Level.Background.Color = Color.Charcoal;
        Level.CreateBottomBorder(1.0, true);
        Level.CreateLeftBorder(1.0, true);
        Level.CreateRightBorder(1.0, true);
        Level.CreateTopBorder(1.0, false);
        PhysicsObject muuri1 = LuoMuuri(Level.Left + 300.0, Level.Bottom + 50.0);
        Add(muuri1);
        PhysicsObject muuri2 = LuoMuuri(muuri1.X + 400.0, muuri1.Y);
        Add(muuri2);
        GameObject vaara1 = LuoVaarat(muuri1.X - 100.0, muuri1.Y - 25.0);
        Add(vaara1);
        GameObject vaara2 = LuoVaarat(muuri1.X + 100.0, muuri1.Y - 25.0);
        Add(vaara2);
        GameObject vaara3 = LuoVaarat(muuri2.X - 100.0, muuri1.Y - 25.0);
        Add(vaara3);
        GameObject vaara4 = LuoVaarat(muuri2.X + 50.0, muuri1.Y - 25.0);
        Add(vaara4);
        GameObject vaara5 = LuoVaarat(muuri1.X + 50.0, muuri1.Y - 25.0);
        Add(vaara5);
        GameObject vaara6 = LuoVaarat(muuri2.X - 50.0, muuri1.Y - 25.0);
        Add(vaara6);
        GameObject goal = LuoMaali(muuri2.X + 150.0, vaara1.Y);
        Add(goal);

        Gravity = new Vector(0, -1500);
        Controls();
        PlayerSettings();
        CameraSettings();
    }


    void Level5()
    {
        Level.Background.Color = Color.Charcoal;
        Level.CreateBottomBorder(1.0, true);
        Level.CreateLeftBorder(1.0, true);
        Level.CreateRightBorder(1.0, true);
        Level.CreateTopBorder(1.0, false);
        PhysicsObject muuri1 = LuoMuuri(Level.Left + 300.0, Level.Bottom + 50.0);
        Add(muuri1);
        PhysicsObject muuri2 = LuoMuuri(muuri1.X + 400.0, muuri1.Y);
        Add(muuri2);
        GameObject vaara1 = LuoVaarat(muuri1.X - 100.0, muuri1.Y - 25.0);
        Add(vaara1);
        GameObject vaara2 = LuoVaarat(muuri1.X + 100.0, muuri1.Y - 25.0);
        Add(vaara2);
        GameObject vaara3 = LuoVaarat(muuri2.X - 100.0, muuri1.Y - 25.0);
        Add(vaara3);
        GameObject vaara4 = LuoVaarat(muuri2.X + 50.0, muuri1.Y - 25.0);
        Add(vaara4);
        GameObject vaara5 = LuoVaarat(muuri1.X + 50.0, muuri1.Y - 25.0);
        Add(vaara5);
        GameObject vaara6 = LuoVaarat(muuri2.X - 50.0, muuri1.Y - 25.0);
        Add(vaara6);
        GameObject goal = LuoMaali(muuri2.X + 150.0, vaara1.Y);
        Add(goal);

        Gravity = new Vector(0, -1500);
        Controls();
        PlayerSettings();
        CameraSettings();
    }


    /// <summary>
    /// LuoMuuri aliohjelma luo seinän jolla on vuorovaikutusta pelaajan kanssa
    /// </summary>
    /// <param name="x">Muurin sijainti x-akselissa</param>
    /// <param name="y">Muurin sijainti y-akselissa</param>
    /// <returns></returns>
    PhysicsObject LuoMuuri(double x, double y)
    {
        double leveys = 50.0;
        double korkeus = 100.0;
        PhysicsObject muuri = PhysicsObject.CreateStaticObject(leveys, korkeus, Shape.Rectangle);
        muuri.Color = Color.Wheat;
        muuri.X = x;
        muuri.Y = y;
        Add(muuri);
        return muuri;
    }


    /// <summary>
    /// LuoVaarat aliohjelma luo tähden jolla on vuorovaikutusta pelaajan kanssa. Toisessa Aliohjelmassa enemmän vuorovaikutuksesta
    /// </summary>
    /// <param name="x">Tähden sijainti x-akselissa</param>
    /// <param name="y">Tähden sijainti y-akselissa</param>
    /// <returns></returns>
    PhysicsObject LuoVaarat(double x, double y)
    {
        double leveys = 50;
        double korkeus = 50;
        PhysicsObject tahti = PhysicsObject.CreateStaticObject(leveys, korkeus, Shape.Star);
        tahti.X = x;
        tahti.Y = y;
        tahti.Color = Color.DarkGreen;
        tahti.Tag = "tahti";
        Add(tahti);
        return tahti;
    }


    PhysicsObject LuoMaali(double x, double y)
    {
        double w = 50;
        double h = 50;
        PhysicsObject maali = new PhysicsObject(w, h, Shape.Heart);
        maali.X = x;
        maali.Y = y;
        maali.Color = Color.RosePink;
        maali.Tag = "maali";
        Add(maali, 1);
        return maali;
    }
    /// <summary>
    /// Kameran asetukset, eli kuinka kamera liikkuu tasoon nähden
    /// </summary>
    void CameraSettings()
    {
        Camera.Follow(player);
        Camera.ZoomFactor = 1.2;
        Camera.StayInLevel = true;
    }


    /// <summary>
    /// Pelaajan asetukset, eli pelaajan muoto ja sijainti pelin alussa
    /// </summary>
    void PlayerSettings()
    {
        double r = 40.0;
        player = new PlatformCharacter(r, r, Shape.Circle);
        player.X = Level.Left + 100;
        player.Y = Level.Bottom + 100;
        player.Color = Color.Maroon;
        AddCollisionHandler(player, "tahti", HitsTahti);
        AddCollisionHandler(player, "maali", InteractWithGoal);
        Add(player);
    }


    /// <summary>
    /// Ohjaimet pelissä, eli pelaajan ohjaimet, sillä muita olioita ei voi ohjata
    /// </summary>
    void Controls()
    {
        Keyboard.Listen(Key.D, ButtonState.Down, Move, "Move left", player, SpeedMove);
        Keyboard.Listen(Key.A, ButtonState.Down, Move, "Move right", player, -SpeedMove);
        Keyboard.Listen(Key.W, ButtonState.Pressed, Leap, "Jump", player, JumpSpeed);

        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");
    }


    /// <summary>
    /// Aliohjelma Move antaa pelaajalle nopeuden. Move-aliohjelmaa haetaan Controls-aliohjelmassa, jossa määritellään pelaajan liikettä
    /// </summary>
    /// <param name="speed"></param>
    void Move(PlatformCharacter friend, double speed)
    {
        friend = player;
        friend.Walk(speed);
    }


    void Leap(PlatformCharacter friend, double speed)
    {
        friend = player;
        friend.Jump(speed);
    }


    void InteractWithGoal(PhysicsObject player, PhysicsObject goal)
    {
        gameLevel++;
        NextLevel();
    }


    void HitsTahti(PhysicsObject player, PhysicsObject tahti)
    {
        DeathScreen();
    }


    void DeathScreen()
    {
        ClearAll();

        MultiSelectWindow deathWindow = new MultiSelectWindow("OOPS, YOU DIED...", "RETRY", "MAIN MENU");
        deathWindow.AddItemHandler(0, NextLevel);
        deathWindow.AddItemHandler(1, MainMenu);
        Add(deathWindow);
    }


    void MainMenu()
    {
        ClearAll();

        gameLevel = 1;

        MultiSelectWindow menu = new MultiSelectWindow("POUNCE", "START GAME", "CHOOSE LEVEL", "QUIT");
        menu.AddItemHandler(0, NextLevel);
        menu.AddItemHandler(1, LevelSelect);
        menu.AddItemHandler(2, ConfirmExit);
        Add(menu);

    }


    void VictoryScreen()
    {
        ClearAll();

        gameLevel = 1;
        MultiSelectWindow victory = new MultiSelectWindow("YOU WIN!", "START AGAIN?", "CHOOSE LEVEL", "MAIN MENU");
        victory.AddItemHandler(0, Level1);
        victory.AddItemHandler(1, LevelSelect);
        victory.AddItemHandler(2, MainMenu);
        Add(victory);
    }


    void LevelSelect()
    {
        MultiSelectWindow levels = new MultiSelectWindow("SELECT A LEVEL", "LEVEL 1", "LEVEL 2", "LEVEL 3", "Level 4", "LEVEL 5");
        levels.AddItemHandler(0, Level1);
        levels.AddItemHandler(1, Level2);
        levels.AddItemHandler(2, Level3);
        levels.AddItemHandler(3, Level4);
        levels.AddItemHandler(4, Level5);
        Add(levels);
    }


}
