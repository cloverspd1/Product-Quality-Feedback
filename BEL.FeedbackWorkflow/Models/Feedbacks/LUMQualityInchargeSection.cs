﻿namespace BEL.FeedbackWorkflow.Models.Feedbacks
{
    using BEL.CommonDataContract;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Web;
    using BEL.FeedbackWorkflow.Models.Common;
    using System.ComponentModel.DataAnnotations;
    using BEL.FeedbackWorkflow.Models.Master;

    [DataContract, Serializable]
    public class LUMQualityInchargeSection : ISection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LUMQualityInchargeSection"/> class.
        /// </summary>
        public LUMQualityInchargeSection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CCQualityInchargeSection"/> class.
        /// </summary>
        /// <param name="isSet">if set to <c>true</c> [is set].</param>
        public LUMQualityInchargeSection(bool isSet)
        {
            if (isSet)
            {
                this.ListDetails = new List<ListItemDetail>() { new ListItemDetail(FeedbackListNames.FEEDBACKLIST, true) };
                this.SectionName = FeedbackSectionName.LUMQUALITYINCHARGESECTION;
                this.ApproversList = new List<ApplicationStatus>();
                this.CurrentApprover = new ApplicationStatus();
                this.MasterData = new List<IMaster>();
                this.MasterData.Add(new ApproverMaster());
            }
        }

        [DataMember, IsListColumn(false), ContainsMasterData(true)]
        public List<IMaster> MasterData { get; set; }

        [DataMember, IsListColumn(false)]
        public int ID { get; set; }


        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public DateTime? QualityInchargeDate { get; set; }

        /// </value>
        [DataMember, IsListColumn(false)]
        public string SectionName { get; set; }

        /// <summary>
        /// Gets or sets the form belong to.
        /// </summary>
        /// <value>
        /// The form belong to.
        /// </value>
        [DataMember, IsListColumn(false)]
        public string FormBelongTo { get; set; }

        /// <summary>
        /// Gets or sets the application belong to.
        /// </summary>
        /// <value>
        /// The application belong to.
        /// </value>
        [DataMember, IsListColumn(false)]
        public string ApplicationBelongTo { get; set; }

        /// <summary>
        /// Gets or sets the list details.
        /// </summary>
        /// <value>
        /// The list details.
        /// </value>
        [DataMember, IsListColumn(false)]
        public List<ListItemDetail> ListDetails { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        [DataMember, IsListColumn(false)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the action status.
        /// </summary>
        /// <value>
        /// The action status.
        /// </value>
        [DataMember, IsListColumn(false)]
        public ButtonActionStatus ActionStatus { get; set; }

        /// <summary>
        /// Gets or sets the current approver.
        /// </summary>
        /// <value>
        /// The current approver.
        /// </value>
        [DataMember, IsListColumn(false), IsApproverDetails(true, FeedbackListNames.FEEDBACKAPPAPPROVALMATRIX)]
        public ApplicationStatus CurrentApprover { get; set; }

        /// <summary>
        /// Gets or sets the approvers list.
        /// </summary>
        /// <value>
        /// The approvers list.
        /// </value>
        [DataMember, IsListColumn(false), IsApproverMatrixField(true, FeedbackListNames.FEEDBACKAPPAPPROVALMATRIX)]
        public List<ApplicationStatus> ApproversList { get; set; }

        /// <summary>
        /// Gets or sets the button caption.
        /// </summary>
        /// <value>
        /// The button caption.
        /// </value>
        [DataMember, IsListColumn(false)]
        public string ButtonCaption { get; set; }

        /// <summary>
        /// Gets or sets the Forward to Quality.
        /// </summary>
        /// <value>
        /// The Forward to Quality.
        /// </value>
        [DataMember, Required, RequiredOnDraft]
        public bool ForwardtoQuality { get; set; }

        /// <summary>
        /// Gets or sets the Project Type.
        /// </summary>
        /// <value>
        /// The project type.
        /// </value>
        //[DataMember, IsPerson(true, true, false), IsViewer]
        //public string QAUser { get; set; }

        ///// <summary>
        ///// Gets or sets the Project Type.
        ///// </summary>
        ///// <value>
        ///// The project type.
        ///// </value>
        //[DataMember, IsPerson(true, true, true), FieldColumnName("QAUser"), IsViewer]
        //public string QAUserName { get; set; }

        [DataMember, IsPerson(true, true, false), IsViewer]
        public string LUMQAUser { get; set; }

        /// <summary>
        /// Gets or sets the Project Type.
        /// </summary>
        /// <value>
        /// The project type.
        /// </value>
        [DataMember, IsPerson(true, true, true), FieldColumnName("LUMQAUser"), IsViewer]
        public string LUMQAUserName { get; set; }

        /// <summary>
        /// Gets or sets the files.
        /// </summary>
        /// <value>
        /// The files.
        /// </value>
        [DataMember, IsFile(true)]
        public List<FileDetails> Files { get; set; }

        /// <summary>
        /// Gets or sets the file name list.
        /// </summary>
        /// <value>
        /// The file name list.
        /// </value>
        [DataMember]
        public string CCQAInchargeFileNameList { get; set; }

        [DataMember, IsListColumn(false)]
        public string BUHidden { get; set; }
    }
}