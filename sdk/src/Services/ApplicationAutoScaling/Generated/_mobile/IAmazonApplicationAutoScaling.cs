/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ApplicationAutoScaling.Model;

namespace Amazon.ApplicationAutoScaling
{
    /// <summary>
    /// Interface for accessing ApplicationAutoScaling
    ///
    /// With Application Auto Scaling, you can automatically scale your AWS resources. The
    /// experience similar to that of <a href="https://aws.amazon.com/autoscaling/">Auto Scaling</a>.
    /// You can use Application Auto Scaling to accomplish the following tasks:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Define scaling policies to automatically scale your AWS resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scale your resources in response to CloudWatch alarms
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// View the history of your scaling events
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Application Auto Scaling can scale the following AWS resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon ECS services. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-auto-scaling.html">Service
    /// Auto Scaling</a> in the <i>Amazon EC2 Container Service Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EC2 Spot fleets. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/fleet-auto-scaling.html">Automatic
    /// Scaling for Spot Fleet</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EMR clusters. For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/ManagementGuide/emr-automatic-scaling.html">Using
    /// Automatic Scaling in Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For a list of supported regions, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#as-app_region">AWS
    /// Regions and Endpoints: Application Auto Scaling</a> in the <i>AWS General Reference</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonApplicationAutoScaling : IAmazonService, IDisposable
    {
                
        #region  DeleteScalingPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterScalableTarget


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterScalableTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterScalableTargetResponse> DeregisterScalableTargetAsync(DeregisterScalableTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScalableTargets


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalableTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalableTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeScalableTargetsResponse> DescribeScalableTargetsAsync(DescribeScalableTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScalingActivities


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScalingPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutScalingPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterScalableTarget


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterScalableTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterScalableTargetResponse> RegisterScalableTargetAsync(RegisterScalableTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}