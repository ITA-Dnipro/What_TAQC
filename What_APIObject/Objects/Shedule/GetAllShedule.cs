using NUnit.Framework;
using System.Net;
using What_APIObject.Entities.Accounts;
using What_APIObject.Entities.Shedule;
using What_Common.Resources;

namespace What_APIObject.API_Object.Shedule
{
    public class GetAllShedule
    {
        private WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;
        private AddShedulesModel.Root newShedule;
        private AllShedulesModel sheduleModel;

        public GetAllShedule(User user)
        {
            client = new WHATClient(user);
        }

        public GetAllShedule GenerateDataForShedule()
        {
            newShedule = new AddShedulesModel.Root
            {
                Context = new AddShedulesModel.Context
                {
                    GroupID = 1,
                    MentorID = 1,
                    ThemeID = 1
                },

                Pattern = new AddShedulesModel.Pattern
                {
                    Type = 1,
                    Interval = 1,
                    DaysOfWeek = new List<int>() { 3 },
                    Index = 0,
                    Dates = new List<int>() { 31 }
                },

                Range = new AddShedulesModel.Range
                {
                    StartDate = DateTime.Now.AddYears(-1),
                    FinishDate = DateTime.Now
                },
            };

            return this;
        }

        public GetAllShedule GenerateWrongDataForShedule()
        {
            newShedule = new AddShedulesModel.Root
            {
                Context = new AddShedulesModel.Context
                {
                    GroupID = 2,
                    MentorID = 1,
                    ThemeID = 1
                },

                Pattern = new AddShedulesModel.Pattern
                {
                    Type = 1,
                    Interval = 1,
                    DaysOfWeek = new List<int>() { 3 },
                    Index = 0,
                    Dates = new List<int>() { 31 }
                },

                Range = new AddShedulesModel.Range
                {
                    StartDate = DateTime.Now.AddYears(1),
                    FinishDate = DateTime.Now
                },
            };

            return this;
        }

        public GetAllShedule CreateNewShedule()
        {
            uri = new Uri(Endpoints.Schedules.schedules, UriKind.Relative);
            var response = client.Post<AddShedulesModel.Root, AllShedulesModel>(uri, newShedule, out statusCode);
            sheduleModel = response;

            return this;
        }

        public GetAllShedule VerifyShedulesBadRequest()
        {
            uri = new Uri(Endpoints.Schedules.schedules, UriKind.Relative);
            var response = client.Post<AddShedulesModel.Root, AllShedulesModel>(uri, newShedule, out statusCode);

            Assert.AreEqual(HttpStatusCode.BadRequest, statusCode);

            return this;
        }

        public GetAllShedule VerifyShedulesForbiden()
        {
            uri = new Uri(Endpoints.Schedules.schedules, UriKind.Relative);
            var response = client.Post<AddShedulesModel.Root, AllShedulesModel>(uri, newShedule, out statusCode);

            Assert.AreEqual(HttpStatusCode.Forbidden, statusCode);

            return this;
        }

        public GetAllShedule VerifyShedulesCreate()
        {
            uri = new Uri(Endpoints.Schedules.schedulesEventsOccurrences, UriKind.Relative);
            var response = client.Get<List<AllShedulesModel>>(uri, out statusCode);
            var createdShedule = response.Find(i => i.Id == sheduleModel.Id);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(createdShedule.StudentGroupId, newShedule.Context.GroupID);
                Assert.AreEqual(createdShedule.EventStart.ToString("yyyy-MM-dd HH:mm"), newShedule.Range.StartDate.AddHours(-2).ToString("yyyy-MM-dd HH:mm"));
                Assert.AreEqual(createdShedule.EventFinish.ToString("yyyy-MM-dd HH:mm"), newShedule.Range.FinishDate.AddHours(-2).ToString("yyyy-MM-dd HH:mm"));
            });

            return this;
        }

        public GetAllShedule VerifyShedulesUnauthorized()
        {
            uri = new Uri(Endpoints.Schedules.schedulesEventsOccurrences, UriKind.Relative);
            var response = client.Get<List<AllShedulesModel>>(uri, out statusCode);

            Assert.AreEqual(HttpStatusCode.Unauthorized, statusCode);

            return this;
        }

        public GetAllShedule VerifyShedulesCreateById()
        {
            uri = new Uri(Endpoints.Schedules.SchedulesById(sheduleModel.Id), UriKind.Relative);
            var response = client.Get<AllShedulesModel>(uri, out statusCode);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(response.StudentGroupId, newShedule.Context.GroupID);
                Assert.AreEqual(response.EventStart.ToString("yyyy-MM-dd HH:mm"), newShedule.Range.StartDate.AddHours(-2).ToString("yyyy-MM-dd HH:mm"));
                Assert.AreEqual(response.EventFinish.ToString("yyyy-MM-dd HH:mm"), newShedule.Range.FinishDate.AddHours(-2).ToString("yyyy-MM-dd HH:mm"));
            });

            return this;
        }

        public GetAllShedule VerifyShedulesCreateByIdDetailed()
        {
            uri = new Uri(Endpoints.Schedules.SchedulesDetailed(sheduleModel.Id), UriKind.Relative);
            var response = client.Get<AddShedulesModel>(uri, out statusCode);

            Assert.Multiple(() =>
            {
                //Assert.AreEqual(response.StudentGroupId, newShedule.Context.GroupID);
                //Assert.AreEqual(response.EventStart.ToString("yyyy-MM-dd HH:mm"), newShedule.Range.StartDate.AddHours(-2).ToString("yyyy-MM-dd HH:mm"));
                //Assert.AreEqual(response.EventFinish.ToString("yyyy-MM-dd HH:mm"), newShedule.Range.FinishDate.AddHours(-2).ToString("yyyy-MM-dd HH:mm"));
            });

            return this;
        }

        public GetAllShedule VerifyShedulesCreateByIdForbiden()
        {
            uri = new Uri(Endpoints.Schedules.schedulesEventsOccurrences, UriKind.Relative);
            var response = client.Get<AllShedulesModel>(uri, out statusCode);

            Assert.AreEqual(HttpStatusCode.Forbidden, statusCode);

            return this;
        }

        public GetAllShedule DeleteShedule()
        {
            uri = new Uri(Endpoints.Schedules.SchedulesEventsOccurrences(sheduleModel.Id), UriKind.Relative);
            var response = client.Delete<AllShedulesModel>(uri, out statusCode);

            return this;
        }
    }
}