 class PlayerShip : Sprite
    {
        //private int speed_;
        private int _widthOfSpace;
        private int speed_ = SPEED;
        private const int WIDTH = 40;
        private const int HEIGHT = 20;
        private const int SPEED = 3;
        private const int GUN_WIDTH = 10;
        private const int GUN_Height = 10;



        public PlayerShip(int screenWidth) : base(300, 290, WIDTH, HEIGHT)
        {
            _widthOfSpace = screenWidth;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Green, X, Y, WIDTH, HEIGHT);
            graphics.FillRectangle(Brushes.Green, X+WIDTH/2-GUN_WIDTH/2, Y-GUN_Height, GUN_WIDTH, GUN_Height);
        }

        public override void Move()
        {
            X += speed_;
            if (X < 0 || X + Width > _widthOfSpace)
            {
                speed_ = -speed_;
            }
        }
    }