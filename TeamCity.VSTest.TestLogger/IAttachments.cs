namespace TeamCity.VSTest.TestLogger
{
    using JetBrains.TeamCity.ServiceMessages.Write.Special;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;

    internal interface IAttachments
    {
        void SendAttachmentSet([NotNull] string testName, [NotNull] AttachmentSet attachmentSet, [NotNull] ITeamCityTestWriter testWriter);
    }
}