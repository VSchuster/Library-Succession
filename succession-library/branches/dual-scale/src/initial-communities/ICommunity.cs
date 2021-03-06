namespace Landis.InitialCommunities
{
    /// <summary>
    /// An initial community.
    /// </summary>
    public interface ICommunity
    {
        /// <summary>
        /// The code that represents the community on maps.
        /// </summary>
        ushort MapCode
        {
            get;
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// The site cohorts in the community.
        /// </summary>
        AgeCohort.ISiteCohorts Cohorts
        {
            get;
        }
    }
}
