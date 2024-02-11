<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="LawyerProfile.aspx.cs" Inherits="ConsultMeTest.LawyerProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
     <style>
     .search-button {
         padding: 10px 20px;
         background-color: aquamarine;
         color: #fff;
         font-size: 18px;
         border: thin;
         border-radius: 5px;
         box-shadow: 4px 8px 10px rgba(0, 0, 0, 0.3);
         cursor: pointer;
         transition: background-color 0.3s ease;
         text-align: center;
         display: inline-block;
         text-decoration: none;
         width: 150px;
         height: 50px;
     }

         .search-button:hover {
             background-color: #dc3545;
         }

             .search-button:hover .larger-text {
                 color: white;
             }



     .larger-text {
         font-family: sans-serif;
         font-size: 24px;
         font-weight: bold;
         display: block;
         color: #001431;
     }
     /* Custom CSS for ASP.NET dropdown options */
     .custom-dropdown {
         font-family: sans-serif;
         background-color: #f4f4f4;
         color: #333;
         border-bottom: 1px solid #ddd;
         width: 200px;
         height: 40px;
     }

         .custom-dropdown:last-child {
             border-bottom: none; /* Remove bottom border for the last option */
         }

         /* Hover effect */
         .custom-dropdown:hover {
             background-color: #e0e0e0;
             color: #000;
         }

     .custom-dropdown-achieve {
         font-family: sans-serif;
         background-color: #f4f4f4;
         color: #333;
         border-bottom: 1px solid #ddd;
         width: 426px;
         height: 40px;
     }
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <br />
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4 class="larger-text">Lawyer Profile Form</h4>
                                </center>
                            </div>
                        </div>
                        <hr />

                        <!-- university,state,district-->
                        <div class="row mx-auto">
                            <div class="col-md-4">
                                <label style="font-weight: bold">University</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="University" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Tribhuvan University (TU)" Value="Tribhuvan University (TU)" />
                                        <asp:ListItem Text="Kathmandu University (KU)" Value="Kathmandu University (KU)" />
                                        <asp:ListItem Text="Pokhara University (PoU)" Value="Pokhara University (PoU)" />
                                        <asp:ListItem Text="Purbanchal University (PU)" Value="Purbanchal University (PU)" />
                                        <asp:ListItem Text="Nepal Sanskrit University" Value="Nepal Sanskrit University" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">State</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="StateDropdown" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Koshi" Value="Koshi" />
                                        <asp:ListItem Text="Madhesh" Value="Madhesh" />
                                        <asp:ListItem Text="Bagmati" Value="Bagmati" />
                                        <asp:ListItem Text="Gandaki" Value="Gandaki" />
                                        <asp:ListItem Text="Lumbini" Value="Lumbini" />
                                        <asp:ListItem Text="Karnali" Value="Karnali" />
                                        <asp:ListItem Text="Sudurpashchim" Value="Sudurpashchim" />

                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">District</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="DistrictDropdown" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Achham" Value="Achham" />
                                        <asp:ListItem Text="Arghakhanchi" Value="Arghakhanchi" />
                                        <asp:ListItem Text="Baglung" Value="Baglung" />
                                        <asp:ListItem Text="Baitadi" Value="Baitadi" />
                                        <asp:ListItem Text="Bajhang" Value="Bajhang" />
                                        <asp:ListItem Text="Bajura" Value="Bajura" />
                                        <asp:ListItem Text="Banke" Value="Banke" />
                                        <asp:ListItem Text="Bara" Value="Bara" />
                                        <asp:ListItem Text="Bardiya" Value="Bardiya" />
                                        <asp:ListItem Text="Bhaktapur" Value="Bhaktapur" />
                                        <asp:ListItem Text="Bhojpur" Value="Bhojpur" />
                                        <asp:ListItem Text="Chitwan" Value="Chitwan" />
                                        <asp:ListItem Text="Dadeldhura" Value="Dadeldhura" />
                                        <asp:ListItem Text="Dailekh" Value="Dailekh" />
                                        <asp:ListItem Text="Dang" Value="Dang" />
                                        <asp:ListItem Text="Darchula" Value="Darchula" />
                                        <asp:ListItem Text="Dhading" Value="Dhading" />
                                        <asp:ListItem Text="Dhankuta" Value="Dhankuta" />
                                        <asp:ListItem Text="Dhanusa" Value="Dhanusa" />
                                        <asp:ListItem Text="Dholkha" Value="Dholkha" />
                                        <asp:ListItem Text="Dolpa" Value="Dolpa" />
                                        <asp:ListItem Text="Doti" Value="Doti" />
                                        <asp:ListItem Text="Gorkha" Value="Gorkha" />
                                        <asp:ListItem Text="Gulmi" Value="Gulmi" />
                                        <asp:ListItem Text="Humla" Value="Humla" />
                                        <asp:ListItem Text="Ilam" Value="Ilam" />
                                        <asp:ListItem Text="Jajarkot" Value="Jajarkot" />
                                        <asp:ListItem Text="Jhapa" Value="Jhapa" />
                                        <asp:ListItem Text="Jumla" Value="Jumla" />
                                        <asp:ListItem Text="Kailali" Value="Kailali" />
                                        <asp:ListItem Text="Kalikot" Value="Kalikot" />
                                        <asp:ListItem Text="Kanchanpur" Value="Kanchanpur" />
                                        <asp:ListItem Text="Kapilvastu" Value="Kapilvastu" />
                                        <asp:ListItem Text="Kaski" Value="Kaski" />
                                        <asp:ListItem Text="Kathmandu" Value="Kathmandu" />
                                        <asp:ListItem Text="Kavrepalanchok" Value="Kavrepalanchok" />
                                        <asp:ListItem Text="Khotang" Value="Khotang" />
                                        <asp:ListItem Text="Lalitpur" Value="Lalitpur" />
                                        <asp:ListItem Text="Lamjung" Value="Lamjung" />
                                        <asp:ListItem Text="Mahottari" Value="Mahottari" />
                                        <asp:ListItem Text="Makwanpur" Value="Makwanpur" />
                                        <asp:ListItem Text="Manang" Value="Manang" />
                                        <asp:ListItem Text="Morang" Value="Morang" />
                                        <asp:ListItem Text="Mugu" Value="Mugu" />
                                        <asp:ListItem Text="Mustang" Value="Mustang" />
                                        <asp:ListItem Text="Myagdi" Value="Myagdi" />
                                        <asp:ListItem Text="Nawalparasi" Value="Nawalparasi" />
                                        <asp:ListItem Text="Nuwakot" Value="Nuwakot" />
                                        <asp:ListItem Text="Okhaldhunga" Value="Okhaldhunga" />
                                        <asp:ListItem Text="Palpa" Value="Palpa" />
                                        <asp:ListItem Text="Panchthar" Value="Panchthar" />
                                        <asp:ListItem Text="Parbat" Value="Parbat" />
                                        <asp:ListItem Text="Parsa" Value="Parsa" />
                                        <asp:ListItem Text="Pyuthan" Value="Pyuthan" />
                                        <asp:ListItem Text="Ramechhap" Value="Ramechhap" />
                                        <asp:ListItem Text="Rasuwa" Value="Rasuwa" />
                                        <asp:ListItem Text="Rautahat" Value="Rautahat" />
                                        <asp:ListItem Text="Rolpa" Value="Rolpa" />
                                        <asp:ListItem Text="Rukum" Value="Rukum" />
                                        <asp:ListItem Text="Rupandehi" Value="Rupandehi" />
                                        <asp:ListItem Text="Salyan" Value="Salyan" />
                                        <asp:ListItem Text="Sankhuwasabha" Value="Sankhuwasabha" />
                                        <asp:ListItem Text="Saptari" Value="Saptari" />
                                        <asp:ListItem Text="Sarlahi" Value="Sarlahi" />
                                        <asp:ListItem Text="Sindhuli" Value="Sindhuli" />
                                        <asp:ListItem Text="Sindhupalchok" Value="Sindhupalchok" />
                                        <asp:ListItem Text="Siraha" Value="Siraha" />
                                        <asp:ListItem Text="Solukhumbu" Value="Solukhumbu" />
                                        <asp:ListItem Text="Sunsari" Value="Sunsari" />
                                        <asp:ListItem Text="Surkhet" Value="Surkhet" />
                                        <asp:ListItem Text="Syangja" Value="Syangja" />
                                        <asp:ListItem Text="Tanahu" Value="Tanahu" />
                                        <asp:ListItem Text="Taplejung" Value="Taplejung" />
                                        <asp:ListItem Text="Terhathum" Value="Terhathum" />
                                        <asp:ListItem Text="Udayapur" Value="Udayapur" />

                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
                        <!-- bar,achievements-->
                        <div class="row mx-auto">
                            <div class="col-md-4">
                                <label style="font-weight: bold">Bar Association Membership</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="Membership" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Yes" Value="Yes" />
                                        <asp:ListItem Text="No" Value="No" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label style="font-weight: bold">Achievements (Any one?)</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown-achieve" ID="Achievements" runat="server" SelectionMethod="Multiple">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Landmark Legal Victories" Value="Landmark Legal Victories" />
                                        <asp:ListItem Text="Industry Awards and Recognitions" Value="Industry Awards and Recognitions" />
                                        <asp:ListItem Text="Notable Client Representations" Value="Notable Client Representations" />
                                        <asp:ListItem Text="Community Impact and Advocacy" Value="Community Impact and Advocacy" />
                                        <asp:ListItem Text="Leadership Roles" Value="Leadership Roles" />
                                        <asp:ListItem Text="Legal Innovations and Publications" Value="Legal Innovations and Publications" />
                                        <asp:ListItem Text="None" Value="None" />
                                    </asp:DropDownList>
                                </div>
                            </div>

                        </div>
                        <br />
                        <!-- catagoty,experience,education -->
                        <div class="row mx-auto">
                            <div class="col-md-4">
                                <label style="font-weight: bold">Area of Experties</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="Catagory" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Criminal Law" Value="Criminal Law" />
                                        <asp:ListItem Text="Civil Law" Value="Civil Law" />
                                        <asp:ListItem Text="Family Law" Value="Family Law" />
                                        <asp:ListItem Text="Corporate Law" Value="Corporate Law" />
                                        <asp:ListItem Text="Real Estate Law" Value="Real Estate Law" />
                                        <asp:ListItem Text="Immigration Law" Value="Immigration Law" />
                                        <asp:ListItem Text="Intellectual Property Law" Value="Intellectual Property Law" />
                                        <asp:ListItem Text="Environmental Law" Value="Environmental Law" />
                                        <asp:ListItem Text="Tax Law" Value="Tax Law" />
                                        <asp:ListItem Text="Employment Law" Value="Employment Law" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Years of Experience</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="Experience" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="0-5 years" Value="0-5 years" />
                                        <asp:ListItem Text="5-10 years" Value="5-10 years" />
                                        <asp:ListItem Text="10+ years" Value="10+ years" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Education</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="Education" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Bachelor's Degree" Value="Bachelor's Degree" />
                                        <asp:ListItem Text="Master's Degree" Value="Master's Degree" />
                                        <asp:ListItem Text="PhD" Value="PhD" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
                        <!-- trial_lawyer,spoken language,contact-->
                        <div class="row mx-auto">
                            <div class="col-md-4">
                                <label style="font-weight: bold">Trial Lawyer?</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="TrialLawyer" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Yes" Value="Yes" />
                                        <asp:ListItem Text="No" Value="No" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Spoken Language</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="language" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Nepali" Value="Nepali" />
                                        <asp:ListItem Text="English" Value="English" />
                                        <asp:ListItem Text="Hindi" Value="Hindi" />
                                        <asp:ListItem Text="All" Value="All" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Contact</label>
                                <asp:TextBox CssClass="form-control" ID="Contact_Num" runat="server" placeholder="Contact Number" BackColor="White" BorderColor="Black" BorderStyle="Solid" TextMode="Phone"></asp:TextBox>
                            </div>

                        </div>
                        <br />
                        <!-- firmname,availability,address-->
                        <div class="row mx-auto">
                            <div class="col-md-4">
                                <label style="font-weight: bold">Firm name (if any)</label>
                                <asp:TextBox CssClass="form-control" ID="Firm_name" runat="server" placeholder="Firm Name" BackColor="White" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Availability</label>
                                <div class="form-group">
                                    <asp:DropDownList class="custom-dropdown" ID="Available" runat="server">
                                        <asp:ListItem Text="Select" Value="Select" />
                                        <asp:ListItem Text="Full-time" Value="Full-time" />
                                        <asp:ListItem Text="Part-time" Value="Part-time" />
                                        <asp:ListItem Text="Contract" Value="Contract" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Office Address</label>
                                <asp:TextBox CssClass="form-control" ID="Office_Address" runat="server" placeholder="Address" BackColor="White" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <!-- case count,case won,available date -->
                        <div class="row mx-auto">
                            <div class="col-md-4">
                                <label style="font-weight: bold">Case Count</label>
                                <asp:TextBox CssClass="form-control" ID="Case_count" runat="server" placeholder="Case Count" BackColor="White" BorderColor="Black" BorderStyle="Solid" TextMode="Number"></asp:TextBox>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Consulting Fee(per hour)</label>
                                <asp:TextBox CssClass="form-control" ID="ConsultingFee" runat="server" placeholder="Amount" BackColor="White" BorderColor="Black" BorderStyle="Solid" TextMode="Number"></asp:TextBox>
                            </div>
                            <div class="col-md-4">
                                <label style="font-weight: bold">Available Date</label>
                                <asp:TextBox CssClass="form-control" ID="Available_date" runat="server" placeholder="Available Date" BackColor="White" BorderColor="Black" BorderStyle="Solid" TextMode="Date"></asp:TextBox>
                            </div>

                        </div>
                        <br />

                        <!-- button-->
                        <div class="row mx-auto">
                            <div class="col">
                                <br />
                                <center>
                                    <div class="form-group">
                                        <asp:LinkButton class="btn btn-info btn-block btn-lg" ID="Submit_profile" runat="server" OnClick="Submit_profile_Click">Submit</asp:LinkButton>
                                    </div>
                                </center>
                            </div>
                        </div>
                    </div>
                    <a href="Homepage.aspx"><< Back to Home</a><br>
                    <br>
                </div>
            </div>
        </div>
    </div>
    <br />
</asp:Content>
