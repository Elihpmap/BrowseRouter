namespace BrowseRouter;

public static class CompatibilityService
{
  public static readonly SemVerNum CurrentVersion = new(0, 15, 0); //TODO this is probably not the best place to define this! I feel like we will forget to increment it one day or another!
  // could we extract it from the Directory.Build.props file instead perhaps?

  public static void CheckConfigCompatibility(SemVerNum configVersion)
  {
    if (configVersion <= new SemVerNum(0, 14, 0))
      _ = new NotifyService(false).NotifyAsync("Config compatibility", "Your config version is OLD! please update it!");
    else if (configVersion > CurrentVersion)
      _ = new NotifyService(false).NotifyAsync("Config compatibility", "Are you from the future");
    //else all is good!
  }

  //public static void ConfigUpdate() // TODO a way to update the config file version to make it easily compatible with newer BrowseRouter versions? 
}

/// <summary>
/// A class to easily compare and parse Semantic Versionning numbers: https://semver.org/
/// </summary>
public class SemVerNum
{
  public readonly uint Major, Minor, Patch;

  public SemVerNum(uint majorVersion, uint minorVersion, uint patchVersion)
  {
    Major = majorVersion;
    Minor = minorVersion;
    Patch = patchVersion;
  }

  public static readonly SemVerNum Zero = new(0, 0, 0);

  public static bool TryParse(string semVerNum, out SemVerNum parsedSemVerNum)
  {
    string[] splittedNums = semVerNum.Split(['.', ',', ':', ' ', '_']);
    if (splittedNums.Length == 3
      && uint.TryParse(splittedNums[0], out uint maj)
      && uint.TryParse(splittedNums[1], out uint min)
      && uint.TryParse(splittedNums[2], out uint patch))
    {
      parsedSemVerNum = new(maj, min, patch);
      return true;
    }

    parsedSemVerNum = Zero;
    return false;
  }

  public override bool Equals(object? obj) =>
    obj is SemVerNum other
    && Major == other.Major
    && Minor == other.Minor
    && Patch == other.Patch;

  public override int GetHashCode() => HashCode.Combine(Major, Minor, Patch);

  public static bool operator ==(SemVerNum a, SemVerNum b)
  => a.Equals(b);

  public static bool operator !=(SemVerNum a, SemVerNum b)
  => !a.Equals(b);

  public static bool operator >(SemVerNum a, SemVerNum b)
    => a.Major > b.Major
    || a.Major == b.Major && a.Minor > b.Minor
    || a.Major == b.Major && a.Minor == b.Minor && a.Patch > b.Patch;

  public static bool operator <(SemVerNum a, SemVerNum b)
    => a.Major < b.Major
    || a.Major == b.Major && a.Minor < b.Minor
    || a.Major == b.Major && a.Minor == b.Minor && a.Patch < b.Patch;

  public static bool operator >=(SemVerNum a, SemVerNum b)
    => a == b || a > b;
  public static bool operator <=(SemVerNum a, SemVerNum b)
    => a == b || a < b;
}
