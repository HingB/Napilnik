namespace IJShooter
{
    class Weapon
    {
        private int _damage;
        private int _bulletsCount;

        public void Fire(Player player)
        {
            player.TakeDamage(_damage);
            _bulletsCount -= 1;
        }
    }

    class Player
    {
        private int _health;

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                return;

            _health -= damage;
        }
    }

    class Bot
    {
        private Weapon _weapon;

        public void OnSeePlayer(Player player)
        {
            _weapon.Fire(player);
        }
    }
}
