namespace Battle.Engine
{
    public class ContractMessages
    {
        public const string ConfigEnemyLevelCanNotBeGreeterThenEnemyLevelDescriptionHave =
            "Configuraion enemy level can not be greeter then EnemyLevelDescription have, enemyLevels.Length > config.Level, enemyId:{0}, required level:{1}, enemy has levels:{2}";

        public const string EnemyDescriptionLevelsCanNotBeNull =
            "EnemyDescription Levels can not be NULL, enemyLevels != null, enemyId:{0}, empty levels";

        public const string EnemyDescriptionCanNotBeNull = "EnemyDescription not found, enemyId:{0}";

        public const string ConfigEnemyLevelMustBeZeroOrGreeter =
            "Configuraion enemy level must be >= 0 (config.Level >= 0)";

        public const string BulletRadiusMustBeGreeterThenZero =
            "CreateBullet, radius must be greeter then 0, need - radius > float.Epsilon";

        public const string BulletWightMustBeGreeterThenZero =
            "CreateBullet, weight(mass) must be greeter then 0, need - weight > float.Epsilon";
    }
}