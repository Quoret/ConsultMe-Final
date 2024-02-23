<%@ Page Title="" Language="C#" MasterPageFile="~/Consult.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="ConsultMeTest.Homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .search-button {
            padding: 10px 20px;
            background-color: aliceblue;
            color: #fff;
            font-size: 18px;
            border: none;
            border-radius: 5px;
            box-shadow: 4px 8px 10px rgba(0, 0, 0, 0.3);
            cursor: pointer;
            transition: background-color 0.3s ease;
            text-align: center;
            display: inline-block;
            text-decoration: none;
            width: 300px;
            height: 85px;
        }

            .search-button:hover {
                background-color: #dc3545;
            }

                .search-button:hover .larger-text {
                    color: white;
                }

                .search-button:hover .upper-text {
                    color: white;
                    font-weight:bold;
                }

        .larger-text {
            font-family: sans-serif;
            font-size: 24px;
            font-weight: bold;
            display: block;
            color: #001431;
        }

        .upper-text {
            color: #dc3545;
            font-family: sans-serif;
            font-weight:bold;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- banner section start -->
    <div class="banner_section layout_padding">
        <div class="container-fluid">
            <div id="banner_slider" class="carousel slide" data-ride="carousel">
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="banner_taital_main">
                                    <h1 class="banner_taital">We Provide Lawyer recommendation</h1>
                                    <p class="banner_text">We use a recommendation system that utilizes your preferences and feedback to match you with suitable lawyers hence enhancing the accessibility and efficiency of legal services.</p>
                                    <div class="readmore_btn active"><a href="#">Read More</a></div>
                                    <div class="started_bt"><a href="#">Contact Us</a></div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="banner_img">
                                    <img src="images/banner-img-edited.png" />
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="carousel-item">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="banner_taital_main">
                                    <h1 class="banner_taital">A user friendly experience</h1>
                                    <p class="banner_text">a user-friendly web app designed with simplicity in mind. Our platform ensures a seamless experience for users of all backgrounds, making it easy for anyone to navigate and utilize its features effortlessly</p>
                                    <div class="readmore_btn active"><a href="#">Read More</a></div>
                                    <div class="started_bt"><a href="#">Contact Us</a></div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="banner_img2">
                                    <img src="images\pexels-buro-millennial-1438081.jpg">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="carousel-item">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="banner_taital_main">
                                    <h1 class="banner_taital">Effortless Expertise</h1>
                                    <p class="banner_text">Discover a world of seamless connections and unparalleled expertise with our platform, "Effortless Expertise." Effortlessly navigate through a diverse pool of professionals, making it a breeze to find and connect with experts in your field</p>
                                    <div class="readmore_btn active"><a href="#">Read More</a></div>
                                    <div class="started_bt"><a href="#">Contact Us</a></div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="banner_img3">
                                    <img src="images/lawyer-in-the-office-square.jpg" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <a class="carousel-control-prev" href="#banner_slider" role="button" data-slide="prev">
                    <i class="fa fa-arrow-left"></i>
                </a>
                <a class="carousel-control-next" href="#banner_slider" role="button" data-slide="next">
                    <i class="fa fa-arrow-right"></i>
                </a>
            </div>
        </div>
    </div>
    <!-- banner section end -->

    <!-- header section end -->
    <!-- box section start -->
    
    <div class="container">
        <div class="box_section">
            <div class="online_box">
                <div class="row mx-auto">
                    <div class="col-md-4">
                        <br />
                        <asp:LinkButton ID="SearchLawyer" runat="server" CssClass="search-button" OnClick="SearchLawyer_Click">
                            <span class="upper-text">Search a</span><br />
                            <span class="larger-text">Lawyer</span>
                        </asp:LinkButton>
                    </div>
                    <div class="col-md-4">
                        <br />
                        <asp:LinkButton ID="SimilarLawyer" runat="server" CssClass="search-button" OnClick="SimilarLawyer_Click">
                            <span class="upper-text">Find similar</span><br />
                            <span class="larger-text">Lawyer</span>
                        </asp:LinkButton>
                    </div>
                    <div class="col-md-4">
                        <br />
                        <asp:LinkButton ID="SearchRequirement" runat="server" CssClass="search-button" OnClick="SearchRequirement_Click1">
                            <span class="upper-text">Search based on</span><br />
                            <span class="larger-text">Requirement</span>
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- box section end -->
    <!-- services section start -->
    <div class="services_section">
        <hr />
        <br />
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <h1 class="studies_taital">SERVICE OFFERINGS</h1>
                </div>
            </div>
        </div>
        <div class="services_section_2">
            <div id="main_slider" class="carousel slide" data-ride="carousel">
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="service_box">
                                        <div class="house_icon">
                                            <img src="images/icon-1.png" class="image_1">
                                            <img src="images/icon-4.png" class="image_2">
                                        </div>
                                        <h3 class="corporate_text">Search lawyers</h3>
                                        <p class="chunks_text">If you know a lawyer, find him at our platform </p>
                                        <div class="readmore_button"><a href="readmore1.aspx">Read More</a></div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="service_box active">
                                        <div class="house_icon">
                                            <img src="images/icon-5.png" class="image_1">
                                            <img src="images/icon-5.png" class="image_2">
                                        </div>
                                        <h3 class="corporate_text">Find similar lawyers</h3>
                                        <p class="chunks_text">We can find you similar lawyers and you can choose</p>
                                        <div class="readmore_button active"><a href="readmore2.aspx">Read More</a></div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="service_box">
                                        <div class="house_icon">
                                            <img src="images/icon-3.png" class="image_1">
                                            <img src="images/icon-6.png" class="image_2">
                                        </div>
                                        <h3 class="corporate_text">Search lawyers acc to requirements</h3>
                                        <p class="chunks_text">We recommend specific lawyer that exactly matches your requirement </p>
                                        <div class="readmore_button"><a href="readmore3.aspx">Read More</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
                <a class="carousel-control-prev" href="#main_slider" role="button" data-slide="prev">
                    <i class="fa fa-arrow-left"></i>
                </a>
                <a class="carousel-control-next" href="#main_slider" role="button" data-slide="next">
                    <i class="fa fa-arrow-right"></i>
                </a>
            </div>
        </div>
    </div>
    <!-- services section end -->
    <!-- studies section start -->
    <!-- studies section end -->
    <!-- about section start -->
    <div class="about_section layout_padding">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <div class="about_img">
                        <img src="images/about-img.png">
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="about_text_main">
                        <h1 class="about_taital">About Us</h1>
                        <p class="about_text">At ConsultMe, we're transforming legal services through our innovative lawyer recommendation platform<span id="dots">...</span><span id="more"></span> Our technology matches clients with suitable attorneys based on legal needs and preferences for an optimized experience. Clients easily discover lawyers, initiate contact, manage cases and communicate seamlessly via our centralized portal. We leverage intelligence and transparency to make quality legal services more efficient, accessible and satisfactory. Our goal is to minimize the hassles associated with legal matters by serving as a trusted partner for all your needs. We aim to enhance client-lawyer relationships and set a new standard in the industry.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- about section end -->
    <!-- testimonial section start -->
    <div class="customer_section layout_padding">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <h1 class="customer_taital">SATISFIED CLIENT Says</h1>
                </div>
            </div>
        </div>
        <div id="my_slider" class="carousel slide" data-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <div class="customer_section_2">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="box_main">
                                        <div class="customer_main">
                                            <div class="customer_left">
                                                <div class="customer_img">
                                                    <img src="images/customer-img.png">
                                                </div>
                                            </div>
                                            <div class="customer_right">
                                                <h3 class="customer_name">Giolio Mark <span class="quick_icon">
                                                    <img src="images/quick-icon.png"></span></h3>
                                                <p class="enim_text">anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internetanything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="carousel-item">
                    <div class="customer_section_2">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="box_main">
                                        <div class="customer_main">
                                            <div class="customer_left">
                                                <div class="customer_img">
                                                    <img src="images/customer-img.png">
                                                </div>
                                            </div>
                                            <div class="customer_right">
                                                <h3 class="customer_name">DenoMark <span class="quick_icon">
                                                    <img src="images/quick-icon.png"></span></h3>
                                                <p class="enim_text">anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internetanything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="carousel-item">
                    <div class="customer_section_2">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="box_main">
                                        <div class="customer_main">
                                            <div class="customer_left">
                                                <div class="customer_img">
                                                    <img src="images/customer-img.png">
                                                </div>
                                            </div>
                                            <div class="customer_right">
                                                <h3 class="customer_name">DenoMark <span class="quick_icon">
                                                    <img src="images/quick-icon.png"></span></h3>
                                                <p class="enim_text">anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internetanything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <a class="carousel-control-prev" href="#my_slider" role="button" data-slide="prev">
                <i class="fa fa-arrow-left"></i>
            </a>
            <a class="carousel-control-next" href="#my_slider" role="button" data-slide="next">
                <i class="fa fa-arrow-right"></i>
            </a>
        </div>
    </div>
    <!-- testimonial section end -->
    <!-- news section start -->

    <!-- news section end -->
    <!-- contact section start -->
    <div class="contact_section layout_padding">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <h1 class="contact_taital">Contact Us</h1>
                </div>
            </div>
            <div class="contact_section_2">
                <div class="row">
                    <div class="col-md-12">
                        <div class="mail_section map_form_container">
                            <form action="">
                                <input type="text" class="mail_text" placeholder="Name" name="Name">
                                <input type="text" class="mail_text" placeholder="Phone Number" name="Phone Number">
                                <input type="text" class="mail_text" placeholder="Your Email" name="Your Email">
                                <textarea class="massage-bt" placeholder="Massage" rows="5" id="comment" name="Massage"></textarea>
                                <div class="send_bt active"><a href="#">Send Now</a></div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- contact section end -->
</asp:Content>
