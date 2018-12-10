﻿namespace BEL.FeedbackWorkflow.Models.Feedbacks
{
    using BEL.CommonDataContract;
    using BEL.FeedbackWorkflow.Models.Common;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Feedbacks Form
    /// </summary>
    [DataContract, Serializable]
    public class FeedbacksForm : IForm
    {
        /// <summary>
        /// Initializes a new instance of the Feedbacks Form class.
        /// </summary>
        /// <param name="setSections">if set to <c>true</c> [set setSections].</param>
        public FeedbacksForm(bool setSections)
        {
            if (setSections)
            {
                this.ApprovalMatrixListName = FeedbackListNames.FEEDBACKAPPAPPROVALMATRIX;
                this.SectionsList = new List<ISection>();
                this.SectionsList.Add(new FeedbacksDetailSection(true));
                this.SectionsList.Add(new CCActingUserSection(true));
                this.SectionsList.Add(new LUMActingUserSection(true));
                this.SectionsList.Add(new CCQualityInchargeSection(true));
                this.SectionsList.Add(new LUMQualityInchargeSection(true));
                this.SectionsList.Add(new QaulityUserSection(true));
                this.SectionsList.Add(new LUMQualityUserSection(true));
                this.SectionsList.Add(new ApplicationStatusSection(true) { SectionName = SectionNameConstant.APPLICATIONSTATUS });
                this.SectionsList.Add(new ActivityLogSection(FeedbackListNames.FEEDBACKACTIVITYLOG));
                this.Buttons = new List<Button>();
                this.MainListName = FeedbackListNames.FEEDBACKLIST;
            }
        }

        /// <summary>
        /// Gets the name of the form.
        /// </summary>
        /// <value>
        /// The name of the form.
        /// </value>
        [DataMember]
        public string FormName
        {
            get { return FeedbacksFormNames.FEEDBACKFORM; }
        }

        /// <summary>
        /// Gets or sets the form status.
        /// </summary>
        /// <value>
        /// The form status.
        /// </value>
        [DataMember]
        public string FormStatus { get; set; }

        /// <summary>
        /// Gets or sets the form approval level.
        /// </summary>
        /// <value>
        /// The form approval level.
        /// </value>
        [DataMember]
        public int FormApprovalLevel { get; set; }


        [DataMember]
        public bool IsField { get; set; }

        /// <summary>
        /// Gets or sets the total approval required.
        /// </summary>
        /// <value>
        /// The total approval required.
        /// </value>
        [DataMember]
        public int TotalApprovalRequired { get; set; }

        /// <summary>
        /// Gets or sets the sections list.
        /// </summary>
        /// <value>
        /// The sections list.
        /// </value>
        [DataMember]
        public List<ISection> SectionsList { get; set; }

        /// <summary>
        /// Gets or sets the buttons.
        /// </summary>
        /// <value>
        /// The buttons.
        /// </value>
        [DataMember]
        public List<Button> Buttons { get; set; }

        /// <summary>
        /// Gets or sets the name of the approval matrix list.
        /// </summary>
        /// <value>
        /// The name of the approval matrix list.
        /// </value>
        [DataMember]
        public string ApprovalMatrixListName { get; set; }

        /// <summary>
        /// Gets or sets the name of the main list.
        /// </summary>
        /// <value>
        /// The name of the main list.
        /// </value>
        [DataMember]
        public string MainListName { get; set; }
    }
}