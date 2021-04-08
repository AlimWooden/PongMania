using UnityEditor;

public class BuildScript
{
    // Start is called before the first frame update
    static void PerformBuild()
    {
        string[] defaultScene = { "Assets/Scenes/MainScene.unity" };
        BuildPipeline.BuildPlayer(defaultScene, "./builds/game.x86_64",
            BuildTarget.StandaloneWindows, BuildOptions.None);
    }

}
